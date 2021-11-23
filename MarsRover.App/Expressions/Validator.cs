namespace MarsRover.App.Expressions
{
    public class Validator
    {
        public PlateauExpression Plateau { get; }
        public PositionExpression Position { get; }
        public MotionExpression Motion { get; }

        public Validator()
        {
            Plateau = new PlateauExpression();
            Position = new PositionExpression();
            Motion = new MotionExpression();
        }
    }
}