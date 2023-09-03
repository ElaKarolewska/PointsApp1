using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsApp1
{
    public interface ICustomer
    {
        string Name { get; set; }
        string Surname { get; set; }
        void AddPoint (string point);
        void AddPoint (int point);
        Statistics GetStatistics();
        void ShowStatistics();
        
        
       

       
    
    }
}
