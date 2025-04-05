public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problem;

    public MathAssignment(string studentName, string topic, string textbookSection, string problem)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problem = problem;
    }

    public string GetHomeworkList()
    {
        string homeworkList = $"Section {_textbookSection} Problems {_problem}";
        return homeworkList;
    }
}