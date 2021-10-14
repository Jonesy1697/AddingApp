using AppliedSystems.Messaging.Infrastructure.Bootstrapping;
using Infrastructure;
using ReceivingApp.Handlers;

namespace ReceivingApp.Bootstrapping
{
    public static class IncomingMessageRoutingConfigurationExtensions
    {
        public static MessageRoutingConfiguration WireUpRouting(this MessageRoutingConfiguration config)
        {
            return config.Incoming
                .ForCommands
                .Handle<AddingCommand>().With<AddingCommandHandler>();
        }
    }
}
