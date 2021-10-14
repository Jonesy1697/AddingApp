using AppliedSystems.Core;
using AppliedSystems.Messaging.Infrastructure.Bootstrapping;
using AppliedSystems.Messaging.MSMQ.Bootstrapping;
using AppliedSystems.Messaging.MSMQ.Configuration;
using ReceivingApp.Bootstrapping;
using SystemDot.Bootstrapping;
using SystemDot.Ioc;

namespace ReceivingApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var msmqConfiguration = MsmqConfiguration.FromAppConfig();

            var msmqReceivePoint = MsmqReceivePoint
            .ForQueues(msmqConfiguration.ReceivingQueues);

            var iocContainer = new IocContainer(t => t.NameInCSharp());

            Bootstrap.Application()
                .ResolveReferencesWith(iocContainer)
                .SetupMessaging()
                .ConfigureReceivingEndpoint(msmqReceivePoint)
                .ConfigureMessagePipeline()
                .ConfigureMessageRouting()
                .WireUpRouting()
                .RegisterConsoleServiceController()
                .Initialise();

            var messageReceiver = iocContainer.Resolve<IServiceController>();

            messageReceiver.StartService();

        }
    }
}
