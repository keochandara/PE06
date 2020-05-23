using System;

namespace MailString
{
    class stringEmail
    {
        static void Main(string[] args)
        {
            string name = "";
            string email = "@abc.com";
            Console.Write("Please input your First name:");
            string firstname = Console.ReadLine();
            Console.Write("Please input your Last name: ");
            string lastname = Console.ReadLine();

            if (lastname.Length < 5)
            {
                name = lastname;
            }
            else
            {
                name = lastname.Substring(0, 5);
            }

            string emailAddress = string.Concat(firstname.Substring(0, 1), name, email);
            Console.WriteLine($"Your email is created: {emailAddress}");
        }
    }
}
