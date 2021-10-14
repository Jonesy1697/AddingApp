using System;

namespace Infrastructure
{
    /// <summary>
    /// Perform print to console commands
    /// </summary>
    public class ConsoleWriter : IOutputWriter
    {
        /// <summary>
        /// Print an integer value to console
        /// </summary>
        /// <param name="output"></param>
        public void PrintInt(int output) =>
            Console.WriteLine(output);

        /// <summary>
        /// Print to console a string message
        /// </summary>
        /// <param name="output">String message to print</param>
        public void PrintString(string output) =>
            Console.WriteLine(output);

        /// <summary>
        /// Print an error message to screen, by changing colour then printing string
        /// </summary>
        /// <param name="output">String message to print</param>
        public void PrintError(string output)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            PrintString(output);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}