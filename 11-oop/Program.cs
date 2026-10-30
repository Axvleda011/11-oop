namespace _11_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClientUser client = new ClientUser(
            "Giorgi",
            "1234",
            "client@gmail.com"
        );

            AdminUser admin = new AdminUser(
                "Admin",
                "admin123",
                "admin@gmail.com"
            );

            
            User user1 = client;
            User user2 = admin;

            user1.Authorization();

            Console.WriteLine();

            user2.Authorization();
        }
    }
}
