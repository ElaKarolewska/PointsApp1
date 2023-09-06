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
        
        private string name;
        private string surname;
        private string fullFileName;
        public CustomerInFile(string name, string surname) : base(name, surname)
        {
            fullFileName = $"{name} {surname} {fileName}";
        }

        public override event Added100PointsDelegate Added100Points;

        public override void AddPoint(string point)
        {
            if (int.TryParse(point, out int result))
            {
                this.AddPoint(result);
            }
            else if (char.TryParse(point, out char charResult))
            {
                this.AddPoint(charResult);
            }
            else 
            {
                throw new Exception("String is not int or char letter.");
            }

        }

        public override void AddPoint(int point)
        {
            if (point >= 0 && point <= 100)
            {
                using (var writer = File.AppendText(fullFileName))
                
                {
                    writer.WriteLine(point);
                }
                if (point == 100) 
                {
                    Added100Points(this, new EventArgs());
                
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
            var result = new Statistics();
            if (File.Exists($"{fullFileName}")) 
            {
                StringBuilder sb = new StringBuilder($"{this.name} {this.surname}");
                
                using (var reader = File.OpenText($"{fullFileName}")) 
                {
                    var line = reader.ReadLine();
                    while (line != null) 
                    {
                        var number = int.Parse(line);
                        result.AddPoint(number);
                        sb.Append($"{line}; ");
                        line = reader.ReadLine();
                    }
                }
                
            }
            
            return result;
        }
    }
}
