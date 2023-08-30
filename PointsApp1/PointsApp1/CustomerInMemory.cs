using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsApp1
{
    public class CustomerInMemory : CustomerBase
    {
        private List<int> points = new List<int>();
        public CustomerInMemory(string name, string surname) : base(name, surname)
        {
        }

        public override void AddPoint(string point)
        {
            throw new NotImplementedException();
        }

        public override void AddPoint(int point)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
