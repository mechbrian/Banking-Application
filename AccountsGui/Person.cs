using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsGui
{
    public class Person
    {
        // Fields
        private string password;

        // Events
        public event EventHandler OnLogin;

        // Properties
        public string Sin { get; }
        public string Name { get; }
        public bool IsAuthenticated { get; private set; }

        // Constructor
        public Person(string name, string sin)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name cannot be empty.", nameof(name));
            if (string.IsNullOrWhiteSpace(sin)) throw new ArgumentException("SIN cannot be empty.", nameof(sin));

            Name = name;
            Sin = sin;
            IsAuthenticated = false;
            password = Sin.Substring(0,3);
        }

        // Methods
        public void Login(string password)
        {
            if (password != this.password)
            {
                IsAuthenticated = false;
                OnLogin.Invoke(this, new LoginEventArgs(Name, false));
                throw new AccountException(ExceptionType.PASSWORD_INCORRECT);
            }
            else
            {
                IsAuthenticated = true;
                OnLogin.Invoke(this, new LoginEventArgs(Name, true));
            }
        }

        public void Logout()
        {
            IsAuthenticated = false;
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            //return $"{Name} is {(IsAuthenticated ? "" : "not ")}authenticated.";
            return Name;
        }
    }
}
