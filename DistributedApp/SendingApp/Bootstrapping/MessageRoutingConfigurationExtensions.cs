using AppliedSystems.Messaging.Infrastructure.Bootstrapping;
using AppliedSystems.Messaging.Infrastructure.Commands.Outgoing;
using Infrastructure;

namespace SendingApp.Bootstrapping
{
    public static class MessageRoutingConfigurationExtensions
    {
        public static MessageRoutingConfiguration WireUpRouting(this MessageRoutingConfiguration config, ICommandDispatchingEndpoint testCommandEndpoint)
        {
            return config
                .Outgoing
                .ForCommands
                .Send<AddingCommand>().ViaEndpoint(testCommandEndpoint);
        }
    }
}
