using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace XGramCounter
{
    public class Program
    {
        static void Main()
        {
            string cipherText = "QNGCAUYUPBLAGWMCCJNBSPCQMGGPVAGSGAIGWHCZZBMRQZBPTHCVUGSOGAGZBWGHCZZBGSVGHUBLLTCKQNGKUASQICLRZGHCZZBKCAQNGRSGCKQNGWGSHGPWBPQSCKQNGHNULWAGPCKZBSQGASBZOUSGWCQQNGZCSQUZVCAQBPQHCVTHCZZBNCOGIGAHCZZBNBSBWUKKGAGPQNUSQCATWCQUQOBSJGVQBQYAGBQSZUBLSHCZZBMRQUQOBSOAUQQGPUPYCPWCAHCZZBVACMBMLTBQQNGAGDRGSQCKQNGYAGBQYABPWSCPCKVGAGYAUPHCZZBBPWHCZVLGQGWUPSWCQAWCQCPGKUIGPUPGQOCWCQKWCQBWCQCPGSGIGPQOCWCQWCQUQSSCRQNGAPSHAUMGBVVGPWGWQNUSPCQGKUPWGYULHCZZBJUPYSOAUQGAHCZZBKUPUSNGWQNUSOCAJUPUICPGSGIGPQOCWCQUQUSBPGXBHQHCVTUPBLLWGQBULSCKQNGQNBUPSMCCJUPZUPBSQUAUQN";

            List<CountList> list = new List<CountList>();

            for (int i = 1; i < 16; i++)
            {
                CountList countList = new CountList();

                for (int j = 0; j < cipherText.Length - i; j++)
                {
                    countList.Length = i;

                    string regex = cipherText.Substring(j, i);
                    if (countList.List == null)
                    {
                        countList.List = new Dictionary<string, int>();
                    }
                    if (!countList.List.Keys.Contains(regex) && Regex.Matches(cipherText, regex).Count > 2)
                    {
                        countList.List.Add(regex, Regex.Matches(cipherText, regex).Count);
                    }
                }

                list.Add(countList);
            }

            foreach(CountList cl in list)
            {
                System.Diagnostics.Debug.WriteLine("Length: " + cl.Length);
                for (int i = 0; i < cl.List.Keys.Count; i++)
                {
                    System.Diagnostics.Debug.WriteLine("Key: " + cl.List.Keys.ElementAt(i) + ", Count: " + cl.List.Values.ElementAt(i));
                }
            }
            Console.ReadKey();
        }
    }
}
