public class Writting : Assignments
{
    private string _title;

    public Writting(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetWrittingInfo()
    {
        return $"{_title}";
    }
}