using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsApp1
{
    public class Statistics
    {
        public int Max;
        public int Min;
        public int Sum;
        public int Count;
        public int Average
        {
            get 
            {
                return Sum / Count;
            }
        
        }
        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = int.MinValue;
            this.Min = int.MaxValue;
        }

        public void AddPoint(int point)
        {
            this.Sum += point;
            this.Count ++;
            this.Min = Math.Min(this.Min, point);
            this.Max = Math.Max(this.Max, point);
        }
    }
}
