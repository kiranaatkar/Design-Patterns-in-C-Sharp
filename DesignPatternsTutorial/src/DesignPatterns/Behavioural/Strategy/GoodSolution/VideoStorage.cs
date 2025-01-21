namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Strategy.GoodSolution
{
    public class VideoStorage
    {
        private ICompressor _compressor;
        private IOverlay _overlay;

        public VideoStorage(ICompressor compressor, IOverlay overlay)
        {
            this._compressor = compressor;
            this._overlay = overlay;
        }

        public void SetCompressor(ICompressor compressor)
        {
            this._compressor = compressor;
        }

        public void SetOverlay(IOverlay overlay)
        {
            this._overlay = overlay;
        }

        public void Store(string video)
        {
            _compressor.Compress();
            _overlay.Apply();
            Console.WriteLine($"Storing video {video}");
        }
    }
}