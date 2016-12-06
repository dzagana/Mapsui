using System;
using System.IO;

namespace Mapsui.Geometries
{
    public class Raster : IRaster
    {
        private readonly BoundingBox _boundingBox;
        public MemoryStream Data { get; }
        public long TickFetched { get; }

        public Raster(MemoryStream data, BoundingBox box)
        {
            Data = data;
            _boundingBox = box;
            TickFetched = DateTime.Now.Ticks;
        }

        public BoundingBox GetBoundingBox()
        {
            return _boundingBox;
        }
        
        public int Dimension => 2;

        public Geometry Envelope()
        {
            throw new NotImplementedException();
        }

        public string AsText()
        {
            throw new NotImplementedException();
        }

        public byte[] AsBinary()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            return _boundingBox.Width * _boundingBox.Height <= 0;
        }

        public Geometry Boundary()
        {
            throw new NotImplementedException();
        }

        public Geometry Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(Geometry geom)
        {
            throw new NotImplementedException();
        }

        public double Distance(Geometry geom)
        {
            throw new NotImplementedException();
        }
    }
}