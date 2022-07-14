using System;
using System.Collections.Generic;
using System.IO;

namespace cse210_02Jumper
{

    // Making ocject for list.
    public class HiddenWord
    {
        public string hiddenword;
        List<char> answer = new List<char>();
        public List<char> guess = new List<char>();

        public HiddenWord()
        {
            
        }

        // Pull the words from my txt file.
        public string getTheRandomWord()
        {
            List<string> lines = new List<string>(File.ReadLines("wordstoguess.txt"));
            Random rand = new Random();
            int randomIndex = rand.Next(0, lines.Count);
            string chosenWord = lines[randomIndex];
            return chosenWord;
        }

        // Next three functions do..
        // Checks how long the word is.
        // Creates "_ _ _ _" for the player to see how long the word is.
        // Prints word.
        public void listWord(string ripWord)
        {
            answer.AddRange(ripWord.ToLower());
        }

        public void createHiddenWord()
        {
            foreach (int i in answer)
            {
                guess.Add('_');
            }
        }

        public void printGuess()
        {
            Console.WriteLine(string.Format("{0}", string.Join(" ", guess)));       
        }

        public int compare(List<char> listPreviousGuesses, int numberOfGuesses)
        {
            for(int i=0;i<answer.Count;i++)
            {
                if (listPreviousGuesses.Contains(answer[i]))
                {
                    guess[i] = answer[i];
                }
            }
            if (answer.Contains(listPreviousGuesses[numberOfGuesses-1]))
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }

        // Prints the answer if player gets it or losses.
        public void printAnswer()
        {
            Console.WriteLine(string.Format("{0}", string.Join(" ", answer)));
        }

    };
}