using System;

public class Program
{
    static void Main(string[] args)
    {
        var commentsGroup1 = new List<Comment>() {
            new Comment("Alejandro Lopez", "I love it! Excited to get one soon."),
            new Comment("Katie Andersen", "This is exciting news!!"),
            new Comment("Austin Hall", "Another version? I think is the same thing as last one."),
        };

        var commentsGroup2 = new List<Comment>() {
            new Comment("Olivia Jackson", "New features? So excited to use it for my exercise routines!"),
            new Comment("Jake Lythgoe", "I like it but I would not spend so much money on this."),
            new Comment("Lesly Goldin", "What I loved the most was the heart rate measurement feature."),
        };

        var commentsGroup3 = new List<Comment>() {
            new Comment("Ryan Hamilton", "I totally disagree, Samsung is way better."),
            new Comment("Jessica Jones", "I think you got good points, but what if both sides are better in different aspects?"),
            new Comment("Mark Rock", "This is great. No wonder why their products are so expensive. Totally worth it."),
        };

        List<Video> videos = new List<Video>()
        {
            new Video("The new iPhone", "Steve Williams", 300, commentsGroup1),
            new Video("Pros and Cons of the Apple Watch", "Hallie Johnson", 730, commentsGroup2),
            new Video("Why is Apple the best?", "Stewart Lewis", 540, commentsGroup3),
        };

        foreach(Video video in videos)
        {
            int count = video.CountComments();
            video.DisplayVideo(count);
        }
    }
}