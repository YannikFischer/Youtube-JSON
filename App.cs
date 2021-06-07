using System;
using System.Collections.Generic;

namespace YouTube
{
    public class App
    {
        public static void Main(string[] args)
        {
            VideoDAO dao = new VideoDAO();

            while (true)
            {
                System.Console.WriteLine("menu");
                System.Console.WriteLine("1: show all");
                System.Console.WriteLine("2: search");

                int selection = Convert.ToInt32(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        System.Console.WriteLine("show all");
                        List<Video> videos = dao.getAllVideos();
                        foreach (var video in videos)
                        {
                            System.Console.WriteLine(video.title + " - " + video.description);
                        }
                        break;
                    case 2:
                        System.Console.WriteLine("search");
                        break;
                    default:
                        System.Console.WriteLine("exit");
                        break;
                }
            }
        }
    }
}