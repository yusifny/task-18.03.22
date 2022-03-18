using System;
using Abst_Polmorph_Interf_Sealed.Models;

namespace Abst_Polmorph_Interf_Sealed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("╭-----Menu----╮");
            Console.WriteLine("|  1.Square   |");
            Console.WriteLine("|2.Rectangular|");
            Console.WriteLine("|   0.Quit    |");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter a side of Square");
                    int side = Convert.ToInt32(Console.ReadLine());

                    Square num = new Square(side);

                    Console.Write("Area of Square is ");
                    Console.WriteLine(num.CalcArea());
                    break;
                case "2":
                    Console.WriteLine("Enter Length");
                    int length = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Width");
                    int width = Convert.ToInt32(Console.ReadLine());

                    Rectangular sides = new Rectangular(width, length);

                    Console.Write("Area of Rectangular is ");
                    Console.WriteLine(sides.CalcArea()); 




                    break;
                default:
                    break;
            }

        }
    }
}
