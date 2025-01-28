using DesignPatternsTutorial.src.DesignPatterns.Structural.Proxy.Good.Package;

namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Proxy.Good
{
    public class YoutubeVideoProxy : Video
    {
        private string _videoId;
        private YoutubeVideo _youtubeVideo;

        public YoutubeVideoProxy(string videoId)
        {
            _videoId = videoId;
        }
        public string GetVideoId()
        {
            return _videoId;
        }

        public void Render()
        {
            if (_youtubeVideo == null)
            {
                // only gets downloaded here when the video is actually rendered
                // and iis only downloaded once.
                _youtubeVideo = new YoutubeVideo(_videoId);
            }
            _youtubeVideo.Render();
        }
    }
}