using System;

namespace Address_Book_System
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName,lastName,address,city,state,email;
            int zip;
            long phoneNumber;
            GetUserData();
            Contacts contacts = new Contacts()
            {
                FirstName = firstName,
                LastName = lastName,
                Address=address,
                City=city,
                State=state,
                Zip=zip,
                PhoneNumber=phoneNumber,
                Email=email
            };  
            void GetUserData()
            {
                Console.WriteLine("Enter First Name");
                firstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name");
                lastName = Console.ReadLine();
                Console.WriteLine("Enter address");
                address = Console.ReadLine();
                Console.WriteLine("Enter city");
                city = Console.ReadLine();
                Console.WriteLine("Enter state");
                state = Console.ReadLine();
                Console.WriteLine("Enter zip code");
                zip = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter phone number");
                phoneNumber = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter email");
                email = Console.ReadLine();
            }
        }       
    }
}
