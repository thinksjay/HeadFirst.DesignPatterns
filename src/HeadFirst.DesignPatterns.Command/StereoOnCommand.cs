namespace HeadFirst.DesignPatterns.Command
{
    public class StereoOnCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOnCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.On();
        }

        public void Undo()
        {
            _stereo.Off();
        }
    }
}