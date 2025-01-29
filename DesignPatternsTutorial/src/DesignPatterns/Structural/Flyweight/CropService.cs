namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Flyweight
{
    public class CropService
    {
        private CropIconFactory cropIconFactory;

        public CropService(CropIconFactory cropIconFactory)
        {
            this.cropIconFactory = cropIconFactory;
        }
        public List<Crop> GetCrops()
        {
            List<Crop> cropList = new List<Crop>();
            cropList.Add(new Crop(1, 2, cropIconFactory.GetIcon(CropType.Carrot)));
            cropList.Add(new Crop(3, 4, cropIconFactory.GetIcon(CropType.Potato)));
            cropList.Add(new Crop(5, 6, cropIconFactory.GetIcon(CropType.Wheat)));
            return cropList;
        }
    }
}