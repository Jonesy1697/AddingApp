using AppliedSystems.Core;
using AppliedSystems.Messaging.Infrastructure;
using AppliedSystems.Messaging.Infrastructure.Receiving;
using System;

namespace ReceivingApp
{
    class MessagingController : IMessagingController
    {
        private readonly IMessageReceiver messageReceiver;
        private readonly IMessageReceivedErrorHandlingPolicy messageReceivedErrorHandlingPolicy;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="messagingRecv"></param>
        /// <param name="errorHandlingPol"></param>
        public MessagingController(IMessageReceiver messagingRecv, IMessageReceivedErrorHandlingPolicy errorHandlingPol)
        {
            messageReceiver = messagingRecv;
            messageReceivedErrorHandlingPolicy = errorHandlingPol;
        }

        /// <summary>
        /// Start monitoring service for messages on MSMQ
        /// </summary>
        public void Start()
        {
            messageReceiver.StartReceiving(HandleReceiverError);
        }

        /// <summary>
        /// Stop monitoring service for messages MSMQ
        /// </summary>
        public void Stop()
        {
            messageReceiver.StopReceiving();
        }

        /// <summary>
        /// Error catching for when receiving a message
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="message"></param>
        private void HandleReceiverError(Exception exception, NotRequired<Message> message)
        {
            messageReceivedErrorHandlingPolicy.HandleMessageReceivingError(exception);
        }
    }
}
