using Infrastructure;

namespace SendingApp
{
    public interface IRouter
    {
        void SendCommand(AddingCommand command);
    }
}
