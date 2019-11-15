using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrambliesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Scramble("rkqodlw", "world"));
            Console.WriteLine(Scramble("cedewaraaossoqqyt", "codewars"));
            Console.WriteLine(Scramble("katas", "steak"));
            Console.WriteLine(Scramble("scriptjavx", "javascript"));
            Console.WriteLine(Scramble("scriptsjava", "javascripts"));
            Console.WriteLine(Scramble("javscripts", "javascript"));
            Console.WriteLine(Scramble("aabbcamaomsccdd", "commas"));
            Console.WriteLine(Scramble("commas", "commas"));
            Console.WriteLine(Scramble("sammoc", "commas"));
        }
        public static bool Scramble(string str1, string str2)
        {
            List<char> string1 = str1.ToList();
            List<char> string2 = str2.ToList();
            var results = string.Empty;

            string1.ForEach(x =>
            {
                var index = string2.FindIndex(y => y == x);
                if (index >= (int)uint.MinValue)
                {
                    string2.RemoveAt(index);

                }
            });

            return string2.Count() == 0;
        }

    }
}
