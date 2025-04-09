// - Added a new custom goal type called "ProgressGoal", which allows users
//   to make incremental progress toward a larger objective (e.g., running a marathon).
// - ProgressGoal awards points for each step of progress and gives a bonus
//   when the goal is fully achieved.
// - This enhances gamification and user engagement beyond the standard goal types.
// ------------------------------------------------------------

using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Show Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    manager.CreateGoal();
                    break;
                case "2":
                    manager.ShowGoals();
                    break;
                case "3":
                    manager.RecordEvent();
                    break;
                case "4":
                    manager.ShowScore();
                    break;
                case "5":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    manager.SaveGoals(saveFile);
                    break;
                case "6":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    manager.LoadGoals(loadFile);
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }
    }
}
