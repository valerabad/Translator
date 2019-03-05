using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatinTransletor
{
    public class Translator
    {        
        private char[] vowelsChar = { 'a', 'e', 'i', 'o', 'u' };
        private char[] alphabetChar = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private char[] consonantsChar;

        public Translator()
        {
            consonantsChar = alphabetChar.Except(vowelsChar).ToArray();
        }

        public string ToPigLatin(string str)
        {
            int countConsonant = 0;
            string[] words = str.Split(' ');
            str = String.Empty;
            for (int i = 0; i < words.Length; i++)
            {
                if (isStartInVowels(words[i]))
                {
                    //rule 1
                    words[i] = words[i] + "ay";
                }

                if (isStartInConsonant(words[i]))
                {
                    // rule 2
                    countConsonant = GetCountConsonantLeters(words[i]);
                    string prefix = words[i].Substring(0, countConsonant);
                    words[i] = words[i].Substring(countConsonant, words[i].Length - countConsonant) + prefix + "ay";
                }

                str += words[i]+" ";
            }
            return str.Trim();
        }

        public bool isStartInVowels(string word)
        {
            if (vowelsChar.Contains<char>(word[0]))
            {
                return true;
            }

            return false;
        }

        public bool isStartInConsonant(string word)
        {
            if (consonantsChar.Contains<char>(word[0]))
            {
                return true;
            }

            return false;
        }

        public int GetCountConsonantLeters(string word)
        {            
            consonantsChar = alphabetChar.Except(vowelsChar).ToArray();
            int countConsonants = 0;
           
            for (int i = 0; i < word.Length; i++)
            {
                char ch = (Convert.ToChar(word[i]));
                if (consonantsChar.Contains<char>(ch))
                {
                    countConsonants++;                    
                }
                else
                {
                    break;
                }

            }

            return countConsonants;
        }
    }
}
