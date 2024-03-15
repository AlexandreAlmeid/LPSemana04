using System;

namespace BetterDecorator
{
    class Program
    {
        private static string Decor( string s , char dec , int num)
        {
            string aux = "";
            for(int i = 0;i < num;i++)
            {
                aux += dec;
            }
            return $"{aux} {s} {aux}";
        }
        static void Main(string[] args)
        {
            string s = args[0];
            char dec = args[1][0];
            int num = int.Parse(args[2]);
            Console.WriteLine(Decor(s, dec, num));
        }
    }
}
