using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractFactory.Shape;

namespace AbstractFactory
{
    internal class ShapeFactory
    {
        public interface IShapeFactory
        {
            IShape CreateCircle();
            IShape CreateSquare();
            IShape CreateTriangle();
        }

        // RedFactory.cs
        public class RedFactory : IShapeFactory
        {
            public IShape CreateCircle() => new RedCircle();
            public IShape CreateSquare() => new RedSquare();
            public IShape CreateTriangle() => new RedTriangle();
        }

        // BlueFactory.cs
        public class BlueFactory : IShapeFactory
        {
            public IShape CreateCircle() => new BlueCircle();
            public IShape CreateSquare() => new BlueSquare();
            public IShape CreateTriangle() => new BlueTriangle();
        }
    }
}
