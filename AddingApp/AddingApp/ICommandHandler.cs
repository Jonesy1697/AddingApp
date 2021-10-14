namespace AddingApp
{
    internal interface ICommandHandler<T>
    {
        void OutputSum(AddingCommand command);

    }
}
