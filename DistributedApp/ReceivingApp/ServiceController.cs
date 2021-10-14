using System;
using Infrastructure;

namespace ReceivingApp
{
    class ServiceController : IServiceController
    {
        private readonly IMessagingController messagingControl;
        private readonly IOutputWriter outputWriter;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="messagingCon"></param>
        /// <param name="writer"></param>
        public ServiceController(IMessagingController messagingCon, IOutputWriter writer)
        {
            outputWriter = writer;
            messagingControl = messagingCon;
        }

        /// <summary>
        /// Main program "loop", keep receiving messages until a key in pressed to stop monitoring processes
        /// </summary>
        public void StartService()
        {
            messagingControl.Start();
            outputWriter.PrintString("Press any key to stop...");
            Console.ReadKey(true);
            outputWriter.PrintError("\nPROCESS HALTING");
            messagingControl.Stop();
        }
    }
}
