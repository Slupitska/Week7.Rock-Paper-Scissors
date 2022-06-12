using System;

namespace ANDOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //AND - && - строгое условие проверки каких-то выражений
            //true && true => true - username && password => welcome!
            //true && false => false - username && password => access denied
            //false && true => false - username && password => access denied
            //false && false => false -username && password => access denied

            //контрольные данные: username - admin, password - "1234"

            string username, password;
            Console.WriteLine("Enter username:");
            username = Console.ReadLine();

            Console.WriteLine("Enter password:");
            password = Console.ReadLine();

            if (username == "admin" && password == "1234")
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Access denied.");
            }
        }
    }
}
