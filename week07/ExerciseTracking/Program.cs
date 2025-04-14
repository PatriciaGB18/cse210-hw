using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        
        Activity running = new Running("03 Nov 2022", 30, 3.0);  
        Activity cycling = new Cycling("03 Nov 2022", 45, 20.0);  
        Activity swimming = new Swimming("03 Nov 2022", 60, 30);  

        
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
