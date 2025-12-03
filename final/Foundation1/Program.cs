using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");

        //create the object of type Video which contains the parameters of title, author, and length of the video
        Video v1 = new Video("Cooking tips ep 11","Jimmy Johnson", 15);
        v1.AddComment(new Comment("XxJacobzXx","thanks for the video. Now I'm able to cook pancakes while I play Minecraft."));
        v1.AddComment(new Comment("Jared007","Video was great!"));

        v1.DisplayVideo(true);


    }
}