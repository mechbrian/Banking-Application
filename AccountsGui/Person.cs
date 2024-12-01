using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsGui
{
    internal class Person
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
        }

        // Methods
        public void Login(string password)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Logout()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override string ToString()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
