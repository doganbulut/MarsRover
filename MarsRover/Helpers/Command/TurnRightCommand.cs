namespace MarsRover.Helpers.Command
{
    public class TurnRightCommand : ICommand
    {
        public bool Execute(Navigator navigator)
        {
            //Turn Right
            navigator.TurnRight();
            return true;
        }
    }
}
