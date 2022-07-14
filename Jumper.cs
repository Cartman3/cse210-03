using System;
using System.Collections.Generic;

namespace cse210_02Jumper
{
    public class Jumper
    {
        private List<string> jumper = new List<string>();
        private int count;
        private int trueTries = 0;

        // Creates the Jumper man.
        public Jumper()
        {
            jumper.Add("  ___");
            jumper.Add(" /___\\");
            jumper.Add(" \\   /");
            jumper.Add("  \\ /");
            jumper.Add("   O");
            jumper.Add("  /|\\");
            jumper.Add("  / \\");
        }

        // Checks to see if you already guessed a letter or not.
        public bool checkInput(List<char> guesses, string currentguess)
        {
            if (guesses.Contains(currentguess[0]))
            {
                Console.WriteLine("You already guessed that letter!");
                return true;
            }
            else
            {
                return false;
            }

        }

        // Tracks number of tries.
        // Tracks what letter was guessed right and where it goes.
        public bool checkJumper(List<char> wordGuess, int tries)
        {
            count = 0;
            for(int i=0;i<wordGuess.Count;i++)
            {
                if (wordGuess[i] != '_')
                {
                    count++;
                }
                else
                {

                }
            }
            if (count == wordGuess.Count)
            {
                return false;
                
            }
            else if(tries == 4)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void printJumper(int tries)
        {
            if (tries == trueTries)
            {

            }
            else if(tries == 4)
            {
                jumper.RemoveRange(0,1);
                jumper[0] = "   X";


            }
            else
            {
                jumper.RemoveRange(0,1);
                trueTries++;
            }
            Console.WriteLine(string.Format("{0}", string.Join("\n", jumper)));
        }
    }
}