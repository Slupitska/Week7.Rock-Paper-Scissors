using System;

namespace Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            //приложение спрашивает пользователя, на какую сумму он сделал покупку в магазине N
            //если сумма чека составила больше 10 евро,
            //то пользователь получает скидку на следующую покупку в размере 1 евро
            //если сумма чека составляет от 20 до 50 евро, то скидка на следующую покупку составляет 5 евро.
            //если сумма чека от 50 до 100 евро, то скидка на следующую покупку - 10 евро
            //если сумма чека превышает 100 евро, то скидка на следующую покупку - 15 евро


            int sumShopping;
            Console.WriteLine("To know the amount of discount on your next shopping, please enter the amount of the last check:");
            sumShopping = Convert.ToInt32(Console.ReadLine());

            if (sumShopping < 10)
            {
                Console.WriteLine("Sorry, discount available for purchases over 10 euro.");
            }
            else if (sumShopping >= 10 && sumShopping <= 20)
            {
                Console.WriteLine(" Your discount for next time is 1 euro.");
            }
            else if (sumShopping >= 20 && sumShopping <= 50)
            {
                Console.WriteLine("Your discount for next time is 5 euro.");
            }
            else if (sumShopping > 50 && sumShopping <= 100)
            {
                Console.WriteLine("Your discount for next time is 10 euro.");
            }
            else
            {
                Console.WriteLine("Your discount for next time is 15 euro!");
            }
            Console.WriteLine("Have a good shopping!");      
        }
    }
}