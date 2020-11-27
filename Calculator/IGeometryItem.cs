namespace Calculator
{
    public interface IGeometryItem
    {
        Point3D Pivot { get; set; }
        void GenerateMeshVertices();
        Point3D BoundingBoxMax { get; }
        Point3D BoundingBoxMin { get; }
        void UpdateVertices();
    }
}