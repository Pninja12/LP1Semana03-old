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
            char character= char.Parse(char_);//troca variável "char_" tipo string por "character" tipo char

            foreach(char s in str)//carácter por carácter da lista de "str"
            {
                if (s != character)//se o "s" for igual à palavra "proibida" então não mostra nada no ecrã
                {
                    Console.Write(s);
                }
            }
        }
    }
}
