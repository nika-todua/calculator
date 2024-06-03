using System;
using System.Linq.Expressions;

namespace ProgramApp
{

    public class Program
    {
        static void Main(string[] args)
        {

            Console.Write("type a number of 1: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Choose \n 1) + \n 2) - \n 3) * \n 4) / \n");
            int zy = Convert.ToInt32(Console.ReadLine());


            Console.Write("type a number of 2: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int xt = x;
            int zyt = zy;
            int yt = y;


            switch (zyt.ToString())
            {
                case "1":
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine($"{xt} + {yt} = {xt + yt}");
                    break;
                case "2":
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine($"{xt} - {yt} = {xt - yt}");
                    break;
                case "3":
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine($"{xt} * {yt} = {xt * yt}");
                    break;
                case "4":
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine($"{xt} ÷ {yt} = {xt / yt}");
                    break;
                default:
                     for( int i = 0; i <= 1000000000; i++)
                    {
                        Console.WriteLine("Error!!");
                    }
                    break;
            }


        }
    }
}