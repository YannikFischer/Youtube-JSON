using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Bson;

namespace YouTube
{
    public class VideoDAO
    {
        public List<Video> getAllVideos()
        {
            MongoClient dbClient = new MongoClient("mongodb://");
            IMongoDatabase db = dbClient.GetDatabase("youtube");
            var vids = db.GetCollection<BsonDocument>("videos");
            var documents = vids.Find(new BsonDocument()).ToList();
            List<Video> videos = new List<Video>();

            foreach (BsonDocument doc in documents)
            {
                System.Console.WriteLine(doc.ToString());
                Video v = new Video(doc["name"].ToString(), "description");
                videos.Add(v);
            }

            List<Video> videos = new List<Video>();

            //mongodb
            videos.Add(new Video("SAW", "Horror"));
            videos.Add(new Video("Frozen", "Cold"));
            videos.Add(new Video("Avengers", "Action"));

            return videos;
        }
    }
}