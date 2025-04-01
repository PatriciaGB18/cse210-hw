public class Assignment
{
    private string _studentName;
    private string _topic;

    // Construtor da classe
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Método para obter o resumo
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}
