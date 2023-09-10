namespace PointsApp1
{ 
    public class CustomerInMemory : CustomerBase
    {
        public override event Added100PointsDelegate Added100Points;
        
        private List<int> points = new List<int>();
        public CustomerInMemory(string name, string surname) : base(name, surname)
        {
        }
        public override void AddPoint(int point)
        {
            if (point >= 0 && point <= 100)
            {
                this.points.Add(point);

                if (point == 100)
                {
                    Added100Points(this, new EventArgs());
                }
            }
            else 
            {
                throw new Exception("Only points from 1 to 100 can be add.");
            }   
            
        }
        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            foreach (var point in this.points) 
            {
                result.AddPoint(point);
            }
            return result;
        }
    }
}
