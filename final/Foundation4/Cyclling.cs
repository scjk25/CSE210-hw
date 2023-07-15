public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }

    public override string GetSummary()
    {
        double pace = GetPace();
        return $"{date:dd MMM yyyy} Cycling ({minutes} min) - Speed: {speed:F1} mph, Pace: {pace:F1} min/mile";
    }
}
