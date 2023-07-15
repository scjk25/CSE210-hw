
public class Assignments
{
    protected string _student_name;
    protected string _topic;

    public Assignments(string name, string topic)
    {
        _student_name = name;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_student_name} - {_topic}";
    }

}