namespace AddingApp
{
    /// <summary>
    /// Perform calculations on the DTO
    /// </summary>
    public class AddingHandler : ICommandHandler<AddingCommand>
    {
        private readonly IWriter Console = new ConsoleWriter();

        /// <summary>
        /// Calculate the value of the DTO print this to the console
        /// </summary>
        /// <param name="command"></param>
        public void OutputSum(AddingCommand command)
        {
            var sum = command.Value1 + command.Value2;
            Console.PrintInt(sum);
        }
    }
}
