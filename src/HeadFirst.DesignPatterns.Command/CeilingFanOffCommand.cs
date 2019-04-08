namespace HeadFirst.DesignPatterns.Command
{

    public class CeilingFanOffCommand : ICommand
    {
        private readonly CeilingFan _ceilingFan;
        private int _prevSpeed;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            _prevSpeed = _ceilingFan.Speed;
            _ceilingFan.Off();
        }
        public void Undo()
        {
            switch (_prevSpeed)
            {
                case CeilingFan.HIGH:
                    _ceilingFan.High();
                    break;
                case CeilingFan.MEDIUM:
                    _ceilingFan.Medium();
                    break;
                case CeilingFan.LOW:
                    _ceilingFan.Low();
                    break;
                default:
                    _ceilingFan.Off();
                    break;
            }
        }
    }
}