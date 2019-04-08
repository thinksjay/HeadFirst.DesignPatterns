namespace HeadFirst.DesignPatterns.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}