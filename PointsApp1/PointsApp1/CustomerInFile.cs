using System.Text;

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
