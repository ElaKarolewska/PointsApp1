namespace PointsApp1
{
    public interface ICustomer
    {
        string Name { get; set; }
        string Surname { get; set; }
        void AddPoint (string point);
        void AddPoint (int point);
        void AddPoint(char point);
        Statistics GetStatistics();
        void ShowStatistics();
        
        event CustomerBase.Added100PointsDelegate Added100Points;
    }
}
