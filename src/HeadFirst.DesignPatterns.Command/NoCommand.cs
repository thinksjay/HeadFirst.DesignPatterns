namespace HeadFirst.DesignPatterns.Command
{
    public class NoCommand : ICommand
    {
        public void Execute() { }
        public void Undo() { }
    }
}