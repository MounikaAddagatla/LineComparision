using System;
using System.Collections.Generic;
using System.Text;

namespace LineLenghtCal
{
    class CaluLength
    {
        public double LengthCal(int x1,int x2,int y1,int y2)
        {
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2)+Math.Pow(y2-y1,2));
            return length;
        }
    }
}
