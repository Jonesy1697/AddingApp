using System;
using System.Text.RegularExpressions;
using Infrastructure;

namespace SendingApp
{
    public class MessageSender : IMessageSender
    {
        private readonly IRouter router;
        const string regex = @"^(\s)*[-]?[0-9]+(\s)*,(\s)*[-]?[0-9]+(\s)*$";

        public MessageSender(IRouter commandRouter)
        {
            router = commandRouter;
        }

        /// <summary>
        /// Validate the message, and if valid, sent a DTO of addingCommand to the router
        /// </summary>
        /// <param name="message">Input string value from the console</param>
        public void SendMessage(string message)
        {
            router.SendCommand(ParseMessage(message));
        }

        /// <summary>
        /// Validate the input against a regular expression, and respond with appropriate result (DTO or null)
        /// </summary>
        /// <param name="message">Console entered string value</param>
        /// <returns>DTO of adding command, containing the compiled values</returns>
        public AddingCommand ParseMessage(string message)
        {
            var tokens = message.Split(',');

            if (Regex.Match(message, regex, RegexOptions.IgnoreCase).Success)
            {
                var addValues = new AddingCommand(int.Parse(tokens[0]), int.Parse(tokens[1]));
                return addValues;
            }

            throw new ArgumentException("Two parameters are required");
        }
    }
}
