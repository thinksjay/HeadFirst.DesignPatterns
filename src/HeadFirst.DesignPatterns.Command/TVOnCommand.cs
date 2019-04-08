namespace HeadFirst.DesignPatterns.Command
{
    public class TVOnCommand : ICommand
    {
        private readonly TV _tv;

        public TVOnCommand(TV tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.On();
            _tv.SetInputChannel();
        }

        public void Undo()
        {
            _tv.Off();
        }
    }
}