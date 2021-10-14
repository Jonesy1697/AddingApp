using System;
using AppliedSystems.Messaging.Infrastructure.Commands;
using Infrastructure;

namespace SendingApp
{
    public class Router : IRouter
    {
        private readonly ICommandDispatcher dispatcher;

        public Router(ICommandDispatcher commandDispatcher)
        {
            dispatcher = commandDispatcher;
        }

        public void SendCommand(AddingCommand command)
        {
            dispatcher.Send(command, Guid.NewGuid(), Guid.NewGuid());
        }
    }
}
