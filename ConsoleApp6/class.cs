using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal struct Reactangle
    {
        private double w, h;
        public double Width {
            get { return w ; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("error must by 0 or postive value");
                }
                else
                    w = value;
            }
        }
        public double Height {
            get { return h; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("error must by 0 or postive value");
                }
                else
                    h = value;
            }
        }

        public double CalculateArea()
        {

            return h*w;
        }
        public void DisplayInfo() {

            Console.WriteLine($"Width={h} Height={w} area={CalculateArea()}");
        }
    }
    internal struct Person
    {

        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public  int GetDistance() 
        {

            return X - Y;
        }
    }
    internal struct Person2
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
