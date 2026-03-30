using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Dune three trailer", "Denis Villenue",3);
        Video video2 = new Video("Toyota Rav4 review", "AutoDinamico",10);
        Video video3 = new Video("Macbook Air Review", "MKBHD", 11);

        Comment comment1Video1 = new Comment("@Daniel", "The war chant sounds like a haka");
        Comment comment2Video1 = new Comment("@theblankyellow", "Lisan al Gaib!");
        Comment comment3Video1 = new Comment("@isaacgarretson", "and the winner for the 2027 Oscars is. dune part 3");

        Comment comment1Video2 = new Comment("@biarritz84", "The front looks like a white laundry basket.");
        Comment comment2Video2 = new Comment("@ricardoaverzano3403", "That interior quality and materials for 40K range is just unacceptable.");
        Comment comment3Video2 = new Comment("@user-qc2tb5lb8f", "Don’t forget the hybrid system and battery warranty.");

        Comment comment1Video3 = new Comment("@starboythekoolkid", "Clearly they put blood sweat and tears into this MacBook");
        Comment comment2Video3 = new Comment("@cartographic", "gives a whole new meaning to bleeding - edge technology");
        Comment comment3Video3 = new Comment("@TheColdLoner", "I still have the M1 and man this thing has not failed me and still feels new and so fast.");

        video1.AddComment(comment1Video1);
        video1.AddComment(comment2Video1);
        video1.AddComment(comment3Video1);

        video2.AddComment(comment1Video2);
        video2.AddComment(comment2Video2);
        video2.AddComment(comment3Video2);

        video3.AddComment(comment1Video3);
        video3.AddComment(comment2Video3);
        video3.AddComment(comment3Video3);

        List<Video> youTubeVideos = new List<Video>();
        youTubeVideos.Add(video1);
        youTubeVideos.Add(video2);
        youTubeVideos.Add(video3);

        foreach (Video video in youTubeVideos)
        {
            Console.WriteLine(video._title);
            Console.WriteLine(video._author);
            Console.WriteLine(video._length);
            Console.WriteLine(video.GetNumberOfComments());
            foreach (Comment comment in video._commentsList)
            {
                Console.WriteLine(comment.GetText());
            }
        }
}
}