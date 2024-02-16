using System;

namespace inluppg6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Text\n2. Helat");
            int menyval = int.Parse(Console.ReadLine());

            switch (menyval)
            {
                case 1: Console.WriteLine("Skriv in två texter");
                    string inputString1 = Console.ReadLine();
                    string inputString2 = Console.ReadLine();
                    Console.WriteLine(Langst(inputString1, inputString2));
                    break;
                case 2: Console.WriteLine("Skriv in två tal");
                    int inputTal1 = int.Parse(Console.ReadLine());
                    int inputTal2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(Langst(inputTal1, inputTal2));
                    break;
            }

            string inupt = Console.ReadLine();
        }

        static string Langst(string inputString1, string inputString2)
        {
            if(inputString1.Length > inputString2.Length)
            {
                return inputString1;
            }
            else if(inputString1.Length < inputString2.Length) { return inputString2; }
            else { return inputString1; }
        }

        static int Langst(int inputInt1, int inputInt2)
        {
            return int.Parse(Langst(inputInt1.ToString(), inputInt2.ToString()));
        }
    }
}