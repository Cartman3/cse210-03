using System;


namespace cse210_02Jumper
{
    // A service that handles terminal operations.
    // The responsibility of a TerminalService is to provide 
    // input and output operations for the terminal.
    public class TerminalService
    {
        // Constructs a new instance of TerminalService.
        public TerminalService()
        {
        }

        // Gets numerical input from the terminal. Directs the user with the given prompt.
        // The given prompt.
        // Inputted number.
        public string ReadGuess(string prompt)
        {
            string rawValue = ReadText(prompt);
            return rawValue;
        }

        // Gets text input from the terminal. Directs the user with the given prompt.
        // The given prompt.
        // Inputted text.
        public string ReadText(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        // Displays the given text on the terminal. 
        // The given text.
        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }
    }
}