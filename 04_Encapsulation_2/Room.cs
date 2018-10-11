using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encapsulation_2
{
    public class Room
    {
        private const double MAX_LENGTH = 30;
        private const double MIN_LENGTH = 6;

        private const double MAX_WIDTH = 30;
        private const double MIN_WIDTH = 6;

        private const double MAX_HEIGHT = 12;
        private const double MIN_HEIGHT = 10;

        private double _length;
        private double _width;
        private double _height;

        public Room(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get => _length;
            private set
            {
                if(value<MIN_LENGTH || value > MAX_LENGTH)
                {
                    throw new ArgumentException($"The length should be between {MIN_LENGTH} and {MAX_LENGTH}.");
                }

                _length = value;
            }
        }

        public double Width
        {
            get => _width;
            private set
            {
                if (value < MIN_WIDTH || value > MAX_WIDTH)
                {
                    throw new ArgumentException($"The width should be between {MIN_WIDTH} and {MAX_WIDTH}.");
                }

                _width = value;
            }
        }

        public double Height
        {
            get => _height;
            private set
            {
                if (value < MIN_HEIGHT || value > MAX_HEIGHT)
                {
                    throw new ArgumentException($"The height should be between {MIN_HEIGHT} and {MAX_HEIGHT}.");
                }

                _height = value;
            }
        }

        public double CalculateLateralSurfaceArea()
        {
            return 2 * _length * _height + 2 * _width * _height;
        }
    }
}
