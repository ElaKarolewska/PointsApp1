using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsApp1
{
    public class CustomerInFile : CustomerBase
    {
        private const string fileName = "points.txt";
        public CustomerInFile(string name, string surname) : base(name, surname)
        {
        }

        

        public override void AddPoint(string point)
        {
            
        }

        public override void AddPoint(int point)
        {
            
        }

        public override Statistics GetStatistics()
        {
       
        }


    }
}
