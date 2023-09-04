using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace PointsApp1
//{
//    public class CustomerInFile : CustomerBase
//    {
//        private const string fileName = "points.txt";
//        public CustomerInFile(string name, string surname) : base(name, surname)
//        {
//        }

        

//        public override void AddPoint(string point)
//        {
//            if (int.TryParse(point, out int result))
//            {
//                this.AddPoint(result);
//            }
//            else
//            {
//                throw new Exception("Only points from 1 to 100 can be add.");
//            }
//        }

//        public override void AddPoint(int point)
//        {
//            if (point >= 0 && point <= 100) 
//            {
//                using (var writer = File.AppendText(fileName)) 
//                {
//                    writer.WriteLine(point);   
//                }
            
            
            
//            }
//        }

//        public override Statistics GetStatistics()
//        {
       
//        }


//    }
//}
