using System;
using AppliedSystems.Core;
using AppliedSystems.Messaging.Infrastructure.Bootstrapping;
using AppliedSystems.Messaging.MSMQ.Dispatching;
using AppliedSystems.Messaging.MSMQ.Dispatching.Configuration.Command;
using SystemDot.Bootstrapping;
using SystemDot.Ioc;
using SendingApp.Bootstrapping;

namespace SendingApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var commandDispatchingConfig = MsmqCommandDispatchingConfiguration.FromAppConfig();

            MsmqCommandEndpoint testCommandEndpoint = MsmqCommandEndpoint
                .ForQueue(commandDispatchingConfig.GetByName("TestCommands").Queue);

            var container = new IocContainer(t => t.NameInCSharp());

            Bootstrap.Application()
                .ResolveReferencesWith(container)
                .SetupMessaging()
                .ConfigureCommandDispatchingEndpoint(testCommandEndpoint)
                .ConfigureMessagePipeline()
                .ConfigureMessageRouting()
                .WireUpRouting(testCommandEndpoint)
                .RegisterMessageSending()
                .Initialise();

            var messageSender = container.Resolve<IMessageSender>();

            while (true)
            {
                var inputLine = Console.ReadLine();

                //Exit loop/program command
                if (inputLine != null && inputLine.ToLower().Equals("exit")) { break; }

                messageSender.SendMessage(inputLine);
            }
        }
    }
}
