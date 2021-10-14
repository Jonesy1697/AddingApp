using AppliedSystems.Messaging.Infrastructure.Commands;
using Infrastructure;

namespace ReceivingApp.Handlers
{
    public class AddingCommandHandler : ICommandHandler<AddingCommand>
    {
        private readonly IOutputWriter OutputWriter;
        public AddingCommandHandler(IOutputWriter writer)
        {
            OutputWriter = writer;
        }

        /// <summary>
        /// Called when input is received, and will then process and pars on the resulting sum
        /// </summary>
        /// <param name="message">Values received and stored in a DTO</param>
        public void Handle(AddingCommand message)
        {
            OutputWriter.PrintInt(CalculateSum(message));
        }

        /// <summary>
        /// Calculates and returns sum from values in the DTO
        /// </summary>
        /// <param name="message">Values received and stored in a DTO</param>
        /// <returns>Sum of values in the DTO</returns>
        public int CalculateSum(AddingCommand message)
        {
            return (message.TermOne+ message.TermTwo);
        }
    }
}
