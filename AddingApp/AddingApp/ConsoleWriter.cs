using System;

namespace AddingApp
{
    /// <summary>
    /// Perform print to console commands
    /// </summary>
    public class ConsoleWriter : IWriter
    {
        /// <summary>
        /// Print an integer value to console
        /// </summary>
        /// <param name="output"></param>
        public void PrintInt(int output) => Console.WriteLine(output);

        /// <summary>
        /// Print an error message to console
        /// </summary>
        /// <param name="output"></param>
        public void PrintError(string output) => Console.WriteLine(output);
    }
}
