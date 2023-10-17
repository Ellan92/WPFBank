namespace WPFBank
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }


        public User()
        {

        }
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }

    public class Admin : User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public Admin(string username, string password, bool isAdmin) : base(username, password)
        {
            Username = username;
            Password = password;
            IsAdmin = true;
        }

    }

    public class Client : User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public Client(string username, string password, bool isAdmin) : base(username, password)
        {
            Username = username;
            Password = password;
            IsAdmin = false;
        }
    }
}
