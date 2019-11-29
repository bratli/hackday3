using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackDayRobot
{
    public class Robot
    {
        List<Vector> vectors = new List<Vector>();

        internal void run(Input input)
        {
            int x1 = input.Start.X;
            int y1 = input.Start.Y;

            int count = 0;


            foreach (var el in input.Commands)
            {
                switch (el.Direction)
                {
                    case "east":
                        vectors.Add(new Vector(el.Steps, 0));
                        break;
                    case "north":
                        vectors.Add(new Vector(0, el.Steps));
                        break;
                    case "south":
                        vectors.Add(new Vector(0, -el.Steps));
                        break;
                    case "west":
                        vectors.Add(new Vector(-el.Steps,0));
                        break;
                    default:
                        throw new Exception();
                }

                count = el.Steps - findNumIntersections();

            }


        }
        int findNumIntersections()
        {
            for ( int i = vectors.Count()-1; i>=0; i-- )
            {
                vectors[i].xSteps;                              
            }
        }
    }


    class Vector
    {
        public Vector(int xSteps, int ySteps)
        {
            this.xSteps = xSteps;
            this.ySteps = ySteps;
        }

        public int xSteps { get; set; }
        public int ySteps { get; set; }           
    }

}
