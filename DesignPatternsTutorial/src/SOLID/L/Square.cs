namespace DesignPatternsTutorial.src.SOLID.L
{
    // violates LSP
    // public class Square : Rectangle
    // {
    //     public override double Width 
    //     {
    //         get => base.Width;
    //         set => base.Width = base.Height = value;
    //     }
    //     public override double Height 
    //     {
    //         get => base.Height;
    //         set => base.Height = base.Width = value;
    //     }
    // }

    public class Square : Shape
    {
        public double Side { get; set; }
        public override double Area => Side * Side;
    }
}