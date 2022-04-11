using System;

namespace _02_Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string rating = Console.ReadLine();
            int night = days - 1;
            double pricePerDay = 0; 
            if (typeOfRoom == "room for one person")
            {
                pricePerDay = 18 * night;
            }else if (typeOfRoom == "apartment")
            {
                pricePerDay = 25 * night;
                if (days > 15)
                {
                    pricePerDay *= 0.5;
                }else if (days >= 10 && days <= 15)
                {
                    pricePerDay += 0.65;
                }else
                {
                    pricePerDay *= 0.7;
                }
            }else if (typeOfRoom == "president apartment")
            {
                pricePerDay = 35 * night;
                if (days > 15)
                {
                    pricePerDay *= 0.8;
                }else if (days >= 10 && days <= 15)
                {
                    pricePerDay *= 0.85;
                }else
                {
                    pricePerDay *= 0.9;
                }
            }if (rating == "negative")
            {
                pricePerDay *= 0.9;
            }else if (rating == "positive")
            {
                pricePerDay *= 1.25;
            }
            Console.WriteLine($"{pricePerDay:F2}");




        }

    }
    }
