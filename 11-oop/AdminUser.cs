using System;
using System.Collections.Generic;
using System.Text;

namespace _11_oop
{
    class AdminUser : User
    {
        public AdminUser() : base()
        {
        }

        public AdminUser(string name, string password, string email)
            : base(name, password, email)
        {
        }

        public override void Authorization()
        {
            Console.WriteLine("Administrator authorization:");
            base.Authorization();
        }
    }
}
