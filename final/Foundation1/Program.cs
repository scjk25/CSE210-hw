class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("How to learn basic principals of c#", "Steve Johnson", 120);
        video1.AddComment("Mary Smith", "Great video!");
        video1.AddComment("George Stephens", "I learned a lot from this.");

        Video video2 = new Video("How to use C# in progaming", "Susan Cruz", 180);
        video2.AddComment("Scott Smith", "Nice explanation!");
        video2.AddComment("Ashley Barret", "Could you provide more examples?");

        Video video3 = new Video("C# used in the real world", "Shane Maxwell", 150);
        video3.AddComment("Frank Miller", "Very informative.");

        // Add videos to a list
        List<Video> videoList = new List<Video> { video1, video2, video3 };

        // Display information for each video
        foreach (Video video in videoList)
        {
            Console.WriteLine("\nTitle: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("\nNumber of comments: " + video.GetCommentCount());

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine("-" + comment.Name + ": " + comment.Text);
            }
            Console.WriteLine();
        }
    }
}