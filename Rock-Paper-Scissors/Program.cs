using System;

namespace Rock_Paper_Scissors
{
    using System;
        class Program
        {
            static void Main(string[] args)
            {
                // ПК будет генерировать три случайных значения, от 1 до 3.
                // 1 - камень, 2 - ножницы, 3 - бумага
                // камень бьет ножницы, ножницы режут бумага, бумага оборачивает камень
                // с помощью if или switch; while (break когда сумма очков = 3) или логические операторы
                //игра должна продолжаться до того момента, пока 1 из игроком не наберет 3 очка.
                //каждая победа в игре оценивается в 1 очко

                int userScore = 0;
                int cpuScore = 0;

                Console.WriteLine("Let's play game from our childhood!");
                Console.WriteLine("Game up to 3 points.");


                while (userScore < 3 && cpuScore < 3)
                {
                    Console.WriteLine("Rock, scissors or paper?");
                    string userChoice = Console.ReadLine().ToLower();

                    Console.WriteLine($"USER Choice {userChoice}");

                    Random rnd = new Random();
                    int random = rnd.Next(1, 4);
                    string cpuChoice = "";

                    switch (random)
                    {
                        case 1:
                            cpuChoice = "paper";
                            break;
                        case 2:
                            cpuChoice = "rock";
                            break;
                        case 3:
                            cpuChoice = "scissors";
                            break;
                    }

                    Console.WriteLine($"CPU choice {cpuChoice}");

                    if ((cpuChoice == "paper" && userChoice == "rock") || (cpuChoice == "scissors" && userChoice == "paper") || (cpuChoice == "rock" && userChoice == "scissors"))
                    {
                        cpuScore++;
                        Console.WriteLine("USER lose. CPU win!");
                    }
                    else if ((userChoice == "rock" && cpuChoice == "scissors") || (userChoice == "paper" && cpuChoice == "rock") || (userChoice == "scissors" && cpuChoice == "paper"))
                    {
                        userScore++;
                        Console.WriteLine("USER win! CPU lose.");
                    }
                    else if (userChoice == cpuChoice)
                    {
                        Console.WriteLine("Draw.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input from USER, please try again.");
                    }

                    Console.WriteLine($"USER score: {userScore} - CPU score: {cpuScore}");

                }

                if (userScore == 3)
                {
                    userScore++;
                    Console.WriteLine("USER is winner!");

                }
                else
                {
                    cpuScore++;
                    Console.WriteLine("Cpu is winner!");

                }

                Console.WriteLine("Let's play again!");
            }
        }
    }