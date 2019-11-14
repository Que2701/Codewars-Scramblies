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
            Console.WriteLine(Scramble("aabbcamaomsccdd", "commas"));
            Console.WriteLine(Scramble("commas", "commas"));
            Console.WriteLine(Scramble("sammoc", "commas"));
        }
        public static bool Scramble(string str1, string str2)
        {
            var r = str1.ToList().Select(x => x).Where(x => str2.Contains(x)).Count();
            return str1.ToList().Select(x => x).Where(x => str2.Contains(x)).Count() == str2.Length;
        }

    }
}
