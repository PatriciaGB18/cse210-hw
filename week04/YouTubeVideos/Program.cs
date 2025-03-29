using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        // Criando vídeos
        Video video1 = new Video("C# Basics", "CodeAcademy", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Nice explanation!"));

        Video video2 = new Video("Advanced C# Techniques", "TechGuru", 1200);
        video2.AddComment(new Comment("Dave", "Awesome content!"));
        video2.AddComment(new Comment("Eve", "This is exactly what I needed."));
        video2.AddComment(new Comment("Frank", "Could you cover more on LINQ?"));

        Video video3 = new Video("C# OOP Concepts", "CodeMaster", 900);
        video3.AddComment(new Comment("Grace", "OOP is making sense now!"));
        video3.AddComment(new Comment("Hank", "Well explained."));
        video3.AddComment(new Comment("Ivy", "Keep up the good work!"));

        // Adicionando vídeos à lista
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Exibindo os detalhes de cada vídeo
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}
