using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checking_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words1 = { "name", "aba", "sand", "racecar", "meme" };
            string[] words2 = { "Dan", "rare", "band", "soft" };
            string[] words3 = { "civic", "aba", "deleveled", "radar" };
            
            //test
            Console.WriteLine("Number of palindromes in words1: " + CountPalindromes(words1));
            Console.WriteLine("Number of palindromes in words2: " + CountPalindromes(words2));
            Console.WriteLine("Number of palindromes in words3: " + CountPalindromes(words3));
        }

        static int CountPalindromes(string[] words)
        {
            int count = 0;

            //Looping through all words and checking if they are palindromes
            foreach (var item in words)
            {
                var s1 = item.ToLower().Where(c => Char.IsLetter(c));
                var s2 = item.ToLower().Reverse().Where(c => Char.IsLetter(c));
                if (s1.SequenceEqual(s2))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
