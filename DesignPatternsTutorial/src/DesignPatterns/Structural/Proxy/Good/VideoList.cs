using DesignPatternsTutorial.src.DesignPatterns.Structural.Proxy.Good.Package;

namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Proxy.Good
{
    public class VideoList
    {
        private Dictionary<string, Video> _videos = new Dictionary<string, Video>();
        
        public void AddVideo(Video video)
        {
            _videos.Add(video.GetVideoId(), video);
        }

        public void Watch(string videoId)
        {
            if (_videos.ContainsKey(videoId))
            {
                _videos[videoId].Render();
            }
            else
            {
                Console.WriteLine("Video with id " + videoId + " not found");
            }
        }
    }
}