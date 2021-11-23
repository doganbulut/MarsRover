namespace MarsRover.Helpers.Command
{
    public class MoveCommand : ICommand
    {
        public bool Execute(Navigator navigator)
        {
            //Move
            return navigator.TryMove();
        }
    }
}
