using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Box : IBox
    {
        private double _width;
        private double _depth;
        private double _height;
        private List<Point3D> _vertices;

        public Point3D Pivot { get; set; }
        public Point3D BoundingBoxMax { get; }
        public Point3D BoundingBoxMin { get; }

        public double Width
        {
            get => _width;
            set
            {
                _width = value;
                UpdateVertices();
            }
        }
        public double Height
        {
            get => _height;
            set
            {
                _height = value;
                UpdateVertices();
            }
        }
        public double Depth
        {
            get => _depth;
            set
            {
                _depth = value;
                UpdateVertices();
            }
        }

        public Box() : this(1, 1, 1)
        {
        }

        public Box(double width, double depth, double height) : this(width, depth, height, new Point3D())
        {
        }

        public Box(double width, double depth, double height, Point3D pivot)
        {
            _width = width;
            _depth = depth;
            _height = height;
            Pivot = pivot;
            GenerateMeshVertices();
            UpdateVertices();
        }

        //   6-----7
        //  /|    /|
        // 4-----5 |     z  
        // | 2---|-3     | y
        // |/    |/      |/
        // 0-----1       0----x
        public void GenerateMeshVertices()
        {
            _vertices = new List<Point3D>();
            for (int i = 0; i < 8; i++)
            {
                _vertices.Add(new Point3D());
            }
        }

        public void UpdateVertices()
        {
            for (int i = 0; i < 8; i++)
            {
                _vertices[i].X = Pivot.X - _depth / 2 * (1 - 2 * i % 2);
                _vertices[i].Y = Pivot.Y - _width / 2 * (-1 + 2 * Math.Floor(i / 2.0) % 2);
                _vertices[i].Z = Pivot.Z + _height * Math.Floor(i / 4.0);
            }
        }

        public double Volume()
        {
            throw new NotImplementedException();
        }
    }
}
