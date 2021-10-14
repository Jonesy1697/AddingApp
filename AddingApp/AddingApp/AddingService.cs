using System.Text.RegularExpressions;

namespace AddingApp
{
    /// <summary>
    /// Validate the inputs
    /// </summary>
    public class AddingService : IAddingService

    {
        private readonly ICommandHandler<AddingCommand> addHandle = new AddingHandler();
        private readonly IWriter Console = new ConsoleWriter();

        /// <summary>
        /// Validate the input has only 2 integer values, separated by a "," when given a input string
        /// Valid inputs    : "1,6", "526  , 2655", "-6, 4"
        /// Invalid inputs  : "1", "Duck, 3", "51 , 51, 15"
        /// </summary>
        public void ValidateInput(string inputLine)
        {
            var tokens = inputLine.Split(',');

            if (ValidInput(inputLine))
            {
                var addValues = new AddingCommand(int.Parse(tokens[0]), int.Parse(tokens[1]));
                addHandle.OutputSum(addValues);
            }
            else
            {
                Console.PrintError("Two parameters are required");
            }

        }

        /// <summary>
        /// Validate the input has only 2 integer values, separated by a "," when given a input string
        /// Valid inputs    : "1,6", "526  , 2655", "-6, 4"
        /// Invalid inputs  : "1", "Duck, 3", "51 , 51, 15"
        /// </summary>
        /// <param name="inputLine">String input from the console</param>
        /// <returns>Result of testing input against regular expression</returns>
        public bool ValidInput(string inputLine)
        {
            const string regex = @"^(\s)*[0-9]+(\s)*,(\s)*[0-9]+(\s)*$";

            if (Regex.Match(inputLine, regex, RegexOptions.IgnoreCase).Success)
            {
                return true;
            }

            return false;
        }
    }
}