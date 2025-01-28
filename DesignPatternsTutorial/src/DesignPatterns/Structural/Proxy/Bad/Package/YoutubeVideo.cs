namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Proxy.Bad.Package
{
    public class YoutubeVideo : Video
    {
        private string _videoId;

        public YoutubeVideo(string videoId)
        {
            _videoId = videoId;
            Download();
        }
        public string GetVideoId()
        {
            return _videoId;
        }

        public void Render()
        {
            Console.WriteLine("Rendering video with id " + _videoId);
        }

        private void Download()
        {
            Console.WriteLine("Downloading video from youtube API with id " + _videoId);
        }
    }
}