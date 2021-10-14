using System;
using AppliedSystems.Core;
using SystemDot.Bootstrapping;
using SystemDot.Ioc;

namespace AddingApp
{
    class Program
    {
        private static void Main()
        {
            IocContainer container = new(t => t.NameInCSharp());    //IocContainer container = new IocContainer(t => t.NameInCSharp());

            BootstrapContainerConfiguration application = Bootstrap.Application();
            BootstrapBuilderConfiguration configuration = application.ResolveReferencesWith(container);

            configuration.RegisterComponents();
            configuration.Initialise();

            var service = container.Resolve<IAddingService>();

            while (true)
            {
                var inputLine = Console.ReadLine();

                //Exit loop/program command
                if (inputLine != null && inputLine.ToLower().Equals("exit")) { break; }

                service.ValidateInput(inputLine);
            }
        }
    }

    public static class Extension
    {
        public static BootstrapBuilderConfiguration RegisterComponents(this BootstrapBuilderConfiguration configuration)
        {
            return configuration.RegisterBuildAction(c => c.RegisterInstance<IWriter, ConsoleWriter>())
                .RegisterBuildAction(c => c.RegisterInstance<ICommandHandler<AddingCommand>, AddingHandler>())
                .RegisterBuildAction(c => c.RegisterInstance<IAddingService, AddingService>());
        }
    }
}