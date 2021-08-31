using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataSolutions
{
    public class Counter
    {
        public static int CountWordsWithLetter(string[] words, char letter)
        {
            int letterCounter = 0;
            char[] signsOfWord = new char[0];
            foreach (string x in words)
            {
                signsOfWord = x.ToCharArray();
                if (Char.ToUpper(signsOfWord[0]) == Char.ToUpper(letter))
                    letterCounter++;
            }

            return letterCounter;
        }

        public static int CountWordsWithLetterFast(string[] words, char letter)
        {
            throw new NotImplementedException();
        }
    }
}
