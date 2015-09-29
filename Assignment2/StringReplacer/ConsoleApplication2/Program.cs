using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cypherText = "QNGCAUYUPBLAGWMCCJNBSPCQMGGPVAGSGAIGWHCZZBMRQZBPTHCVUGSOGAGZBWGHCZZBGSVGHUBLLTCKQNGKUASQICLRZGHCZZBKCAQNGRSGCKQNGWGSHGPWBPQSCKQNGHNULWAGPCKZBSQGASBZOUSGWCQQNGZCSQUZVCAQBPQHCVTHCZZBNCOGIGAHCZZBNBSBWUKKGAGPQNUSQCATWCQUQOBSJGVQBQYAGBQSZUBLSHCZZBMRQUQOBSOAUQQGPUPYCPWCAHCZZBVACMBMLTBQQNGAGDRGSQCKQNGYAGBQYABPWSCPCKVGAGYAUPHCZZBBPWHCZVLGQGWUPSWCQAWCQCPGKUIGPUPGQOCWCQKWCQBWCQCPGSGIGPQOCWCQWCQUQSSCRQNGAPSHAUMGBVVGPWGWQNUSPCQGKUPWGYULHCZZBJUPYSOAUQGAHCZZBKUPUSNGWQNUSOCAJUPUICPGSGIGPQOCWCQUQUSBPGXBHQHCVTUPBLLWGQBULSCKQNGQNBUPSMCCJUPZUPBSQUAUQN";
            string plainText;

            // 442 assignment 2.1 key
            plainText = cypherText.Replace('Q', 't');
            plainText = plainText.Replace('N', 'h');
            plainText = plainText.Replace('G', 'e');
            plainText = plainText.Replace('H', 'c');
            plainText = plainText.Replace('C', 'o');
            plainText = plainText.Replace('Z', 'm');
            plainText = plainText.Replace('B', 'a');
            plainText = plainText.Replace('W', 'd');
            plainText = plainText.Replace('P', 'n');
            plainText = plainText.Replace('M', 'b');
            plainText = plainText.Replace('R', 'u');
            plainText = plainText.Replace('U', 'i');
            plainText = plainText.Replace('S', 's');
            plainText = plainText.Replace('A', 'r');
            plainText = plainText.Replace('L', 'l');
            plainText = plainText.Replace('Y', 'g');
            plainText = plainText.Replace('J', 'k');
            plainText = plainText.Replace('V', 'p');
            plainText = plainText.Replace('T', 'y');
            plainText = plainText.Replace('K', 'f');
            plainText = plainText.Replace('I', 'v');
            plainText = plainText.Replace('O', 'w');
            plainText = plainText.Replace('D', 'q');
            plainText = plainText.Replace('X', 'x');

            for (int i = 0; i < plainText.Length; i++)
            {
                if (char.IsLower(plainText[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.Write(plainText[i]);
                System.Diagnostics.Debug.Write(plainText[i]);
            }

            Console.ReadKey();
        }
    }
}
