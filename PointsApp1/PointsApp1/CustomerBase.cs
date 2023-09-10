namespace PointsApp1
{
    public abstract class CustomerBase: ICustomer
    { 
        public delegate void Added100PointsDelegate(object sender, EventArgs args);
        
        public abstract event Added100PointsDelegate Added100Points;
        public CustomerBase(string name, string surname) 
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get;  set; }
        public string Surname { get; set; }
        public void AddPoint(char point) 
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
        public void AddPoint(string point) 
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
        public abstract void AddPoint(int point);
        public abstract Statistics GetStatistics();
        public void ShowStatistics()
        {
            var statistics= GetStatistics();

            Console.WriteLine($"{Name} {Surname} STATISTICS:");
            Console.WriteLine();
            Console.WriteLine($"Total points {statistics.Sum}:");
            Console.WriteLine($"Min {statistics.Min}:");
            Console.WriteLine($"Max {statistics.Max}:");
            Console.WriteLine($"Average {statistics.Average:N2}:");
            Console.WriteLine(" \n" + " ");
        }
    }
}
