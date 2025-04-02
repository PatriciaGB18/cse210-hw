class BreathingActivity : Activity
{
    
    public BreathingActivity() 
        : base("Breathing", "This activity will help you relax by guiding you through slow breathing exercises.") 
    {
    }

    
    public void Run()
    {
        DisplayStartingMessage(); 

        Console.WriteLine("\nLet's begin...\n");

        
        int cycles = _duration / 6; 

        for (int i = 0; i < cycles; i++)
        {
            Console.Write("Inhale... ");
            ShowCountDown(4);

            Console.Write("Exhale... ");
            ShowCountDown(2); 

            Console.WriteLine();
        }

        DisplayEndingMessage(); 
    }
}
