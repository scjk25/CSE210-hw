
public class Math : Assignments
{
    private string _textBookSection;
    private string _problems;

    public Math(string name, string topic, string textBookSection, string problems ) : base(name, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }


}