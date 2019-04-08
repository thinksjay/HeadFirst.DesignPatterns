namespace HeadFirst.DesignPatterns.Command
{
    public class LivingroomLightOffCommand : ICommand
    {
        private readonly Light _light;

        public LivingroomLightOffCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.Off();
        }
        public void Undo()
        {
            _light.On();
        }
    }

}