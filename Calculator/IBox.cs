namespace Calculator
{
    public interface IBox : IGeometryItem
    {
        double Width { get; set; }
        double Height { get; set; }
        double Depth { get; set; }
        double Volume();
    }
}