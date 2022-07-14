// Name:
//  Carter Brown
// Assignment:
// cse210-03, Jumper

using cse210_02Jumper;


namespace cse210_02Jumper
{
    // The program's entry point.
    class Program
    {
        // Main that starts and runs the program in director.
        static void Main(string[] args)
        {
            // making director an object
            Director director = new Director();
            director.StartGame();
        }
    }
}