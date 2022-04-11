using System;

namespace _17._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());

            if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        double result = count * 2.70;
                        break;
                    case "apple":
                        result = count * 1.25;
                        break;
                    case "orange":
                        result = count * 0.90;
                        break;
                    case "grapefruit":
                        result = count * 1.60;
                        break;
                    case "kiwi":
                        result = count * 3.00;
                        break;
                    case "pineapple":
                        result = count * 5.60;
                        break;
                    case "grapes":
                        result = count * 4.20;
                        break;
                }
            }
            else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        double result = count * 2.50;
                        break;
                    case "apple":
                        result = count * 1.20;
                        break;
                    case "orange":
                        result = count * 0.85;
                        break;
                    case "grapefruit":
                        result = count * 1.45;
                        break;
                    case "kiwi":
                        result = count * 2.70;
                        break;
                    case "pineapple":
                        result = count * 5.50;
                        break;
                    case "grapes":
                        result = count * 3.85;
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.WriteLine($"{result:F2}");
            }
        }
    }

