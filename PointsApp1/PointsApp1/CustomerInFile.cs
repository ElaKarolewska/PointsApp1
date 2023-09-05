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

        public override event Added100PointsDelegate Added100Points;

        public override void AddPoint(string point)
        {
            if (int.TryParse(point, out int result))
            {
                this.AddPoint(result);
            }
            else
            {
                throw new Exception("Only points from 1 to 100 can be add.");
            }
        }

        public override void AddPoint(int point)
        {
            if (point >= 0 && point <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(point);
                }



            }
        }

        public override void AddPoint(char point)
        {
            switch (point)
            {
                case 'A' or 'a':
                    this.AddPoint(50);
                    break;
                case 'B' or 'b':
                    this.AddPoint(40);
                    break;
                case 'C' or 'c':
                    this.AddPoint(30);
                    break;
                case 'D' or 'd':
                    this.AddPoint(20);
                    break;
                case 'E' or 'e':
                    this.AddPoint(10);
                    break;
                default: throw new Exception("Wrong letter!");

            }
        }

        public override Statistics GetStatistics()
        {

        }


    }
}
