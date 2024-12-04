using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsGui
{
    internal class LoginEventArgs : EventArgs
    {
        public string PersonName { get; }
        public bool Success { get; }

        public LoginEventArgs(string PersonName, bool Success)
        {
            this.PersonName = PersonName;
            this.Success = Success;
        }
    }
}
