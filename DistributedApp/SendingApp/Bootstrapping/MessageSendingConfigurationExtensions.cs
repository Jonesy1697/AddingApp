using SystemDot.Bootstrapping;

namespace SendingApp.Bootstrapping
{
    public static class MessageSendingConfigurationExtensions
    {
        public static BootstrapBuilderConfiguration RegisterMessageSending(this BootstrapBuilderConfiguration config)
        {
            return config
                .RegisterBuildAction(c => c.RegisterInstance<IRouter, Router>())
                .RegisterBuildAction(c => c.RegisterInstance<IMessageSender, MessageSender>());
        }
    }
}
