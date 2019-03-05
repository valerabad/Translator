using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatinTransletor
{
    public class Program
    {        
        static void Main(string[] args)
        {
            
            string testWords = "a on to yalantis away three test hello world pig latin";
            Console.WriteLine(testWords);

            Translator traslator = new Translator();
            string result =  traslator.ToPigLatin(testWords);

            Console.WriteLine(result);
            Console.ReadKey();
        }       
    }
}
