namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Flyweight
{
    public class CropIconFactory
    {
        private Dictionary<CropType, CropIcon> _cropIcons = new Dictionary<CropType, CropIcon>();
        public CropIcon GetIcon(CropType cropType)
        {
            if (!_cropIcons.ContainsKey(cropType))
            {
                _cropIcons.Add(cropType, new CropIcon(cropType, null));
            }
            return _cropIcons[cropType];
        }
    }
}