using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String: ");
            string str = Console.ReadLine();
            Console.Write("Char: ");
            string char_ = Console.ReadLine();

            foreach (string s in str)
            {
                if (s != char_)
                {
                    Console.Write(s);
                }
            }
        }
    }
}
