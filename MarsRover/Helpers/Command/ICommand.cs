namespace MarsRover.Helpers.Command
{
    public interface ICommand
    {
        bool Execute(Navigator navigator);
    }
}
