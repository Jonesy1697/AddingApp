using AppliedSystems.Messaging.Infrastructure.Bootstrapping;
using AppliedSystems.Messaging.Infrastructure.Receiving;
using Infrastructure;
using ReceivingApp.Handlers;
using SystemDot.Bootstrapping;

namespace ReceivingApp.Bootstrapping
{
    public static class ConsoleControllerConfigurationExtensions
    {
        public static BootstrapBuilderConfiguration RegisterConsoleServiceController(this BootstrapBuilderConfiguration config)
        {
            return config
                .RegisterBuildAction(c => c.RegisterCommandHandlingFromAssemblyOf<AddingCommandHandler>())
                .RegisterBuildAction(c => c.RegisterInstance<IMessageReceivedErrorHandlingPolicy, StopSleepAndRestartMessageReceivedErrorHandlingPolicy>())
                .RegisterBuildAction(c => c.RegisterInstance<IMessagingController, MessagingController>())
                .RegisterBuildAction(c => c.RegisterInstance<IServiceController, ServiceController>())
                .RegisterBuildAction(c => c.RegisterInstance<IOutputWriter, ConsoleWriter>());
        }
    }
}
