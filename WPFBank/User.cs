using System;

namespace WPFBank
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Salary { get; set; }


        public User()
        {

        }
        public User(string username, string password, int salary)
        {
            Username = username;
            Password = password;
            Salary = salary;
        }
        private int RandomMoney()
        {
            Random random = new();
            int randomMoney = random.Next(0, 1001);
            return randomMoney;
        }
    }

    public class Admin : User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }


        public Admin(string username, string password, bool isAdmin, int salary) : base(username, password, salary)
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
