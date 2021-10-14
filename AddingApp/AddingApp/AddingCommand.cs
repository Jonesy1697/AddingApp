namespace AddingApp
{
    /// <summary>
    /// Data transfer object to store values
    /// </summary>
    public class AddingCommand : IAddingCommand
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }

        public AddingCommand(int v1 = 0, int v2 = 0)
        {
            Value1 = v1;
            Value2 = v2;
        }
    }
}
