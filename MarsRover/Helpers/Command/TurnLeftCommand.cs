namespace MarsRover.Helpers.Command
{
    public class TurnLeftCommand : ICommand
    {
        public bool Execute(Navigator navigator)
        {
            //Turn Left
            navigator.TurnLeft();
            return true;
        }
    }
}
