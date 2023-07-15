public class Running : Activity
{
    private double distance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / (minutes / 60.0);
    }

    public override double GetPace()
    {
        return minutes / distance;
    }

    public override string GetSummary()
    {
        double speed = GetSpeed();
        double pace = GetPace();
        return $"{date:dd MMM yyyy} Running ({minutes} min) - Distance: {distance:F1} miles, Speed: {speed:F1} mph, Pace: {pace:F1} min/mile";
    }
}
