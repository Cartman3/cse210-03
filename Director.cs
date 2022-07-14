using System;
using System.Collections.Generic;

namespace cse210_02Jumper
{
    // The responsibility of a Director is to control the sequence of play.
    public class Director
    {

        // Making objects.
        // Some of these are Private because I dont want them to be changed except through methods.
        private bool isPlaying = true;
        private string chosenWord;

        private TerminalService terminalService = new TerminalService();
        public HiddenWord hiddenWord = new HiddenWord();
        private Jumper jumper = new Jumper();
        public int tries = 0;
        public int numberOfGuesses = 0;

        private bool checkInput;

        List<char> guessedLetters = new List<char>();

        public string currentGuess = "test";


        // Constructs a new instance of Director.
        public Director()
        {
        }

        // Starts the game and pulls the the following functions here.
        public void StartGame()
        {
            startUpMessages();
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        // Prints hint message and some advice for the player.
        // Pulls the word from my txt file.
        // Prints how many letters it is with "_ _ _ _" or however long it is.
        // Private because I dont want the player to access or change these.
        private void startUpMessages()
        {
            Console.WriteLine("\nHint: Kinds of soda");
            Console.WriteLine("There are a couple tricky ones!");
            Console.WriteLine("\nA couple also have a space,");
            Console.WriteLine("so guess the letters first then the spaces will be obvious.");
            chosenWord = hiddenWord.getTheRandomWord();
            hiddenWord.listWord(chosenWord);
            hiddenWord.createHiddenWord();
            hiddenWord.printGuess();
        }

        // Prints messages and tries.
        // Keeps track of inputted letters.
        // Private because these are changed based on methods of the game
        // not to be changed outright here.
        private void GetInputs()
        {
            Console.WriteLine("\n");
            jumper.printJumper(tries);
            checkInput = true;
            while (checkInput)
            {
                currentGuess = terminalService.ReadGuess("\nGuess a letter [a-z]: ");
                checkInput = jumper.checkInput(guessedLetters, currentGuess);
            }
            guessedLetters.Add(currentGuess[0]);
            

        }

        // Tracks number of guesses.
        private void DoUpdates()
        {
            numberOfGuesses = guessedLetters.Count;
            int usedTries = hiddenWord.compare(guessedLetters, numberOfGuesses);
            tries = tries + usedTries;
            isPlaying = jumper.checkJumper(hiddenWord.guess, tries);
        }

        // Prints answers or loses parts of the parachute.
        private void DoOutputs()
        {
            Console.WriteLine("\n");
            if (isPlaying)
            {
                hiddenWord.printGuess();
            }
            else
            {
                jumper.printJumper(tries);
                hiddenWord.printAnswer();
                Console.WriteLine("\n");
            }
        }
    }
}