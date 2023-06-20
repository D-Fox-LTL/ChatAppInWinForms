//--------------------------------------------------------------------------------------------------------
//      Class: TCPClient and TCPListener for chatroom server
//      Author: D-Fox-LTL
//      Date:   20.june 2023
//--------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace ChatAppForms
{
    internal class clsTCPServer
    {
                //vars
        //TCP listener for the server
        public TcpListener tcplServer;
        //TCP client for the server
        public TcpClient tcpcServer;
        //Had to do this, it was doing some error 120
        SessionManager mobjSessionManager = new SessionManager();
        // bool if the server is running
        public bool blServerRunning;
        //Socket for communication
        public Socket SocketToUse = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

        //Readlock sth like mutex
        public volatile Object objReadLock;

        //Constructor
        public clsTCPServer()
        {
            //init of vars
            blServerRunning = false;

            objReadLock = new Object();
        }

        

        /// <summary>
        /// Starts the server
        /// </summary>
        /// <param name="intPort"> chosen port </param>
        public void StartServer(int intPort)
        {
            //using localhost
            IPAddress IPa = IPAddress.Parse("127.0.0.1");

            try
            {
                //Starts listener for new connections
                tcplServer = new TcpListener(IPa, intPort);
                tcplServer.Start();
                //Server is running
                blServerRunning = true;
            }
            catch (Exception e)
            {
                //Shows exception in MessageBox
                MessageBox.Show(e.Message);
                blServerRunning = false;
            }
        }


        /// <summary>
        /// Stops the server
        /// </summary>
        public void StopServer()
        {
            try
            {
                //Stops the TCP listener
                tcplServer.Stop();
                blServerRunning = false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        /// <summary>
        /// Getting message
        /// </summary>
        /// <param name="socket"> Socket in networking can be thought of as an endpoint for communication between two computers over a network. 
        /// A socket consists of an IP address and a port number. </param>
        /// <returns> Ret message </returns>
        public string GetMessage(Socket socket)
        {
            //provides a stream-based interface for reading from and writing to a network connection.
            //It is commonly used in network programming to handle data transmission and reception over network sockets
            NetworkStream ntwStream = new NetworkStream(socket);
            //Decrypts gotten message
            IFormatter formatter = new BinaryFormatter();
            try
            {
                //retrieving the serialized object so that it can be stored in memory
                string message = (string)formatter.Deserialize(ntwStream);
                return message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }


        /// <summary>
        /// Will send message to sockets
        /// </summary>
        /// <param name="message">This is a message to send</param>
        /// <param name="socket">These are the packets to send them to</param>
        public void SendMessage(string message, Socket socket)
        {
            //NetworkStream provides a stream-based interface for reading from and writing to a network connection.
            //It is commonly used in network programming to handle data transmission and reception over network sockets
            NetworkStream ntwStream = new NetworkStream(socket);
            //Decrypts gotten message
            IFormatter formatter = new BinaryFormatter();
            try
            {
                //process of bringing an object into a structure that is composed in memory
                formatter.Serialize(ntwStream, message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Does the listening
        /// </summary>
        public void TCPListen(TextBox txtBox)
        {
            while (blServerRunning == true)
            {
                try
                {
                    MessageBox.Show("Listening for new connections...");
                    //if client connects,we make a new client and a session for the user
                    TcpClient tcpClient = tcplServer.AcceptTcpClient();         //this.
                    Session session = new Session();
                    session.client = tcpClient;
                    mobjSessionManager.AddSession(session);
                    txtBox.Text = session + " just hoped onto a server! Hope you brought pizza\r";

                }
                catch (Exception e) { MessageBox.Show(e.Message); }
            }
        }


        /// <summary>
        /// checks if any data came over the network
        /// </summary>
        /// <param name="txtBox"> need for the process data, it will appear in the chat window</param>
        public void DataCheck(TextBox txtBox)
        {
            while (blServerRunning == true)
            {
                try
                {       //Locks the reading like a mutex
                    lock (objReadLock) 
                    {           //If there's at least one session
                        if (mobjSessionManager.SessionList.Count > 0)
                        {           //for every session ln the list
                            foreach (Session session in mobjSessionManager.SessionList.ToList())
                            {           //if session isn't null and has some data
                                if (session != null && session.client.GetStream().DataAvailable)
                                {
                                    Thread.Sleep(50);
                                    //Gets the message
                                    string message = GetMessage(session.client.Client);

                                    //if there's actually some info in the message, start a thread for processing data
                                    if (message != null)
                                    {
                                        Thread thrProcessData = new Thread(() => this.ProcessData(session, message, txtBox));
                                        thrProcessData.Start();
                                    }
                                }
                            }    
                        }
                    }
                }
                catch (Exception e) { MessageBox.Show(e.Message); }
            }
        }

        public void QuitCheck(TextBox txtBox)
        {
            while (blServerRunning == true)
            {
                try
                {
                    foreach (Session sessionCheck in mobjSessionManager.SessionListCheck.ToList())
                    {
                        if (mobjSessionManager.SessionList.Contains(sessionCheck) == false) 
                        { 
                            txtBox.Text = sessionCheck + " was disconnected\r";
                            mobjSessionManager.SessionListCheck.Remove(sessionCheck);
                        }
                    }
                }
                catch (Exception e) { MessageBox.Show(e.Message); }
            }
        }


        public void ProcessData(Session session, string message, TextBox txtBox)
        {
            if (session.user != null)
            {
                txtBox.Text = session + ": " + message + "\r";
            }
        }

    }


                            /// <summary>
                            /// New Classes
                            /// </summary>



            //Give each user own token to see better

    public class Session
    {
        //Each person gets Token, client for the communication and user
        public Guid Token;
        public User user;
        public TcpClient client;
        public Session()
        {
            this.Token = Guid.NewGuid();
            this.user = null;
            this.client = null;
        }
    }

            //To see which users are connected
    [Serializable()]
    public class User : IComparable<User>
    {
        public string login;
        public IPAddress IPa;
        public User(string uname, IPAddress IPaOther)
        {
            this.login = uname;
            this.IPa = IPaOther;
        }
        public int CompareTo(User other)
        {
            if (this.login == other.login) return 0;
            else return -1;
        }
    } 

            //Manages clsSession        

    public class SessionManager
    {
        //List for all the sessions going on
        public List<Session> SessionList;
        public List<Session> SessionListCheck;
        public SessionManager() 
        {
            SessionList = new List<Session>();
        }

        /// <summary>
        /// Adds session
        /// </summary>
        /// <param name="SessionOther"> Incoming session to compare</param>
        public void AddSession(Session SessionOther)
        {
            foreach (Session Session in SessionList.ToList())
            {
                if (Session.Token != SessionOther.Token) SessionList.Add(SessionOther); SessionListCheck.Add(SessionOther);
            }
        }


        /// <summary>
        /// Removes the session
        /// </summary>
        /// <param name="TokenOther"> Token to compare</param>
        public void RemoveSession(Guid TokenOther)
        {
            //Need a new var to delete if token exists in a db
            Session sessionToDelete = null;

            foreach (Session Session in SessionList.ToList())
            {
                if (Session.Token == TokenOther) sessionToDelete = Session;
            }
            
            SessionList.Remove(sessionToDelete);
        }
    }

            //Manages clsUser

    public class UserManager
    {
        //list of connected users
        public List<User> UserList;
        //list of banned IPa
        public List<IPAddress> IPAddressBanList;
        public UserManager() 
        {
            UserList = new List<User>();
            IPAddressBanList = new List<IPAddress>();
        }


        //Adds a new User depending on login (uname) and IPa
        public void AddUser(string login, IPAddress IPa)
        {
            try
            {
                foreach (User user in UserList.ToList())
                {
                    //Add user if uname doesn't already exists and IPa isn't banned
                    if (user.login != login && IPAddressBanList.Contains(IPa) == false) UserList.Add(new User(login, IPa));
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        //Removes user depending on a login
        public void RemoveUser(string login)
        {
            //var to save through the login to del the user
            User userToDelete = null;

            foreach (User user in UserList.ToList())
            {
                //if comparing logins equals true, delete it 
                if (user.login == login) userToDelete = user;
            }

            //deletes user
            UserList.Remove(userToDelete);
        }


        /// <summary>
        /// Bans user
        /// </summary>
        /// <param name="login"></param>
        public void BanUser(string login)
        {
            //var to save through the login to del the user
            User userToBan = null;
            foreach (User user in UserList.ToList())
            {
                if (user.login == login) IPAddressBanList.Add(user.IPa); userToBan = user;
            }

            UserList.Remove(userToBan);
        }
    }
}
