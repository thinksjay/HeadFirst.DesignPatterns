namespace HeadFirst.DesignPatterns.Command
{

    public class LivingroomLightOnCommand : ICommand
    {
        private readonly Light _light;

        public LivingroomLightOnCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.On();
        }
        public void Undo()
        {
            _light.Off();
        }
    }
}