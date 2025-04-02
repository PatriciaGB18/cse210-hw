class GratitudeActivity : Activity
{
    public GratitudeActivity() : base("Gratitude Activity", "Take a moment to reflect on things you are grateful for.")
    {
    }

    public virtual void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nList three things you are grateful for:");
        List<string> gratitudeList = new List<string>();

        for (int i = 1; i <= 3; i++)
        {
            Console.Write($"   {i}. ");
            string gratitude = Console.ReadLine();
            gratitudeList.Add(gratitude);
        }

        Console.WriteLine("\nThank you for reflecting on gratitude!");
        
        DisplayEndingMessage();
    }
}
