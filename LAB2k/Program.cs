using System;

namespace LAB2k
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter color number 1-7");
            try
            {
                int a = int.Parse(Console.ReadLine());
                Colors(a);

            }
            catch (FormatException)
            {
                Console.WriteLine("Enter Numbers(1-7)");
                int a = int.Parse(Console.ReadLine());
                Colors(a);


            }
        }
        public static void Colors(int a)
        {
            switch (a)
            {
                case 1:
                    Console.WriteLine("Red");
                    break;
                case 2:
                    Console.WriteLine("Orange");
                    break;
                case 3:
                    Console.WriteLine("Yellow");
                    break;
                case 4:
                    Console.WriteLine("Green");
                    break;
                case 5:
                    Console.WriteLine("Azure");
                    break;
                case 6:
                    Console.WriteLine("Blue");
                    break;
                case 7:
                    Console.WriteLine("Violet");
                    break;
                default:
                    Console.WriteLine("The color is unknown ");
                    break;
            }
        }
    }
}
