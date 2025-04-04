class ListingActivity : Activity
{
    private List<string> _prompts; 

    public ListingActivity() 
        : base("Listing", "This activity will help you focus on the good things in your life by listing them.") 
    {
        _prompts = new List<string>
        {
            "List as many positive things in your life as you can.",
            "List things you are grateful for.",
            "List things that make you happy.",
            "List people who have helped you in life.",
            "List good things that happened to you recently."
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        Console.WriteLine("\nGet ready...");
        ShowSpinner(3); 
        
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("Start listing your items:");

        DateTime startTime = DateTime.Now; 
        DateTime endTime = startTime.AddSeconds(_duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                count++;
            }
        }

        Console.WriteLine($"\nYou listed {count} items!");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random randomGenerator = new Random(); 
        int index = randomGenerator.Next(_prompts.Count);
        return _prompts[index];
    }
}
