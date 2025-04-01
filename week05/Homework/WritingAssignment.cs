public class WritingAssignment : Assignment
{
    private string _title;

    // Construtor chamando o da classe base
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    // Método para obter informações do trabalho de escrita
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }

    // Método para acessar o nome do estudante
    public string GetStudentName()
    {
        return GetSummary().Split(" - ")[0]; // Extrai o nome do estudante
    }
}
