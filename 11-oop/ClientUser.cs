using System;
using System.Collections.Generic;
using System.Text;

namespace _11_oop
{
    class ClientUser : User
    {
        public ClientUser() : base()
        {
        }

        public ClientUser(string name, string password, string email)
            : base(name, password, email)
        {
        }

        public override void Authorization()
        {
            Console.WriteLine("Client authorization:");
            base.Authorization();
        }
    }

}
