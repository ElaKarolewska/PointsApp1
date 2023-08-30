using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsApp1
{
    public class Statistics
    {
        public int Max { get; set; }
        public int Min { get; set; }
        public int Total { get; set; }

        public Statistics()
        {
            this.Total = 0;
            this.Max = int.MinValue;
            this.Min = int.MaxValue;
        }

        public void AddPoint(int point)
        {
            this.Total += point;
            this.Min = Math.Min(this.Total, point);
            this.Max = Math.Max(this.Total, point);
        }
    }
}
