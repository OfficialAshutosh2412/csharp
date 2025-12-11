using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class VowelFinder
    {
        internal void find()
        {
            Console.Write("enter a character to check : ");
            string character = Console.ReadLine()!;
            if (character.Length != 1) Console.WriteLine("invalid input : enter only one character...");
            else
            {
                switch (character.ToLower())
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u":
                        Console.Write("vowel");
                        break;

                    default:
                        int op = 0;
                        char firstchar = character[0];
                        if ((int.TryParse(character, out op))) Console.Write("numeric");
                        else if (char.IsLetter(firstchar)) Console.WriteLine("consonant");
                        else Console.Write("invalid input : you entered special character");
                        break;
                }
            }
        }
    }
}
