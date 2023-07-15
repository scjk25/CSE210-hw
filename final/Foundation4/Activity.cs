public class Activity
{
    protected DateTime date;
    protected int minutes;

    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return "";
    }

    protected string FormatTime(double time)
    {
        int hours = (int)time / 60;
        int minutes = (int)time % 60;
        return $"{hours:D2}:{minutes:D2}";
    }
}