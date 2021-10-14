using Infrastructure;

namespace SendingApp
{
    public interface IMessageSender
    {
        void SendMessage(string message);
        AddingCommand ParseMessage(string inputString);
    }
}
