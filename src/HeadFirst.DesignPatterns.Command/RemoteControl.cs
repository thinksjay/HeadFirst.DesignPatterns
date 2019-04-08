using System.Text;
using System;

namespace HeadFirst.DesignPatterns.Command
{
    //
    // This is the invoker
    //
    public class RemoteControl
    {
        private ICommand[] _onCommands;
        private ICommand[] _offCommands;
        private ICommand _undoCommand;

        public RemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            ICommand _noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                _onCommands[i] = _noCommand;
                _offCommands[i] = _noCommand;
            }
            _undoCommand = _noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }

        public void UndoButtonWasPushed()
        {
            _undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"{Environment.NewLine}------ Remote Control -------{Environment.NewLine}");
            for (int i = 0; i < _onCommands.Length; i++)
            {
                stringBuilder.Append($"[slot {i}] {_onCommands[i].GetType().Name}    {_offCommands[i].GetType().Name}{Environment.NewLine}");
            }
            
            stringBuilder.Append("[undo] {_undoCommand.GetType().Name}{Environment.NewLine}");
            return stringBuilder.ToString();
        }
    }
}