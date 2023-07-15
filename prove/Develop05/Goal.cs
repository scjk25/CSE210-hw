
public abstract class Goal
{
    protected internal string name;
    protected internal int points;

    public Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
    }

    public abstract bool IsComplete();
    public abstract void MarkComplete();
    public abstract string GetProgress();


}