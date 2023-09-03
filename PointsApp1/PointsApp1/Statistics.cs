using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsApp1
{
    public class Statistics
    {
        public int Max;
        public int Min;
        public int Total;
        public int Count;

        public Statistics()
        {
            this.Count = 0;
            this.Total = 0;
            this.Max = int.MinValue;
            this.Min = int.MaxValue;
        }

        public void AddPoint(int point)
        {
            this.Total += point;
            this.Count += 0;
            this.Min = Math.Min(this.Total, point);
            this.Max = Math.Max(this.Total, point);
        }
    }
}
