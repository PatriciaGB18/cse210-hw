class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
        : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience.") 
    {
        _prompts = new List<string>
        {
            "Think of a time when you did something really difficult.",
            "Think of a moment when you helped someone in need.",
            "Think of a time when you achieved something great.",
            "Remember a situation where you overcame a challenge."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "What did you learn from this moment?",
            "How did you feel when it was happening?",
            "What can you take from this experience to apply in the future?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nTake a deep breath and get ready...");
        ShowSpinner(3);

        string prompt = GetRandomPrompt();
        Console.WriteLine($"\nConsider this prompt: {prompt}");
        Console.WriteLine("Take a few moments to reflect...");
        ShowSpinner(5); 

        DisplayQuestions();

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    private void DisplayQuestions()
    {
        Console.WriteLine("\nNow, consider these questions:");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.Write($"\n{question} ");
            ShowSpinner(5); 
        }
    }
}
