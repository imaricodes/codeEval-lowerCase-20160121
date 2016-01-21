using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeEval_lowerCase_20160121
{
    class Program
    {
        static void Main(string[] args)
        {
            //**Given a string write a program to convert it into lowercase.

            //**INPUT SAMPLE:
            //**The first argument will be a path to a filename containing sentences, one per line. You can assume all characters are from the english language.E.g.
            //**HELLO CODEEVAL
            //**This is some text
            //**OUTPUT SAMPLE:
            //**Print to stdout, the lowercase version of the sentence, each on a new line.E.g.
            //**hello codeeval
            //**this is some text
            //**Solved

            //string line = "BIG bad TonY WAS aSLEEp";
            

            
            string[] input = line.Split(' ');
  
            for (int i = 0; i < input.Length; i ++)
            {
                input[i] = input[i].ToLower();
                Console.Write(input[i] + " ");
            }
            Console.WriteLine();




            Console.ReadKey();
        }
    }
}
