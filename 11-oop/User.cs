using System;
using System.Collections.Generic;
using System.Text;

namespace _11_oop
{

    abstract class User
    {
        
        private string name;
        private string password;
        private string email;

        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        
        public User()
        {
            name = "Unknown";
            password = "";
            email = "";
        }

        
        public User(string name, string password, string email)
        {
            this.name = name;
            this.password = password;
            this.email = email;
        }

        
        public virtual void Authorization()
        {
            Console.Write("Enter email: ");
            string enteredEmail = Console.ReadLine() ?? "";

            Console.Write("Enter password: ");
            string enteredPassword = Console.ReadLine() ?? "";

            if (enteredEmail == Email &&
                enteredPassword == Password)
            {
                Console.WriteLine("Authorization successful!");
            }
            else
            {
                Console.WriteLine("Invalid email or password!");
            }
        }
    }


}
