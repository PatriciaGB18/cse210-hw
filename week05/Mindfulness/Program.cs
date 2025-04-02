// Changes and additions implemented in the program:
// 1. Added a new "Gratitude Activity" where users write three things they are grateful for.
// 2. Ensured that random prompts in the Reflecting Activity are not repeated until all have been used.
// 3. Improved the Breathing Activity animation to make inhaling slower at first and then exhaling faster.
// 4. Added a log feature to track how many times each activity has been performed in a session.

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program!\n");
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Gratitude Activity"); 
            Console.WriteLine("5. Exit");
            Console.Write("\nEnter your choice: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
            else if (choice == "4")
            {
                GratitudeActivity gratitude = new GratitudeActivity();
                gratitude.Run();
            }

            else if (choice == "5")
            {
                Console.WriteLine("\nThank you for using the Mindfulness Program. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("\nInvalid choice. Please enter a number from 1 to 4.");
                Thread.Sleep(2000); 
            }
        }
    }
}
