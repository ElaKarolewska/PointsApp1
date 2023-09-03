using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PointsApp1
{
    public abstract class CustomerBase: ICustomer
    {
        
        
       
        public CustomerBase(string name, string surname) 
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; set; }
        public string Surname { get; set; }

        public abstract void AddPoint (string point);
        public abstract void AddPoint(int point);

        public abstract Statistics GetStatistics();

        public void ShowStatistics()
        {
            
        }
    }
}
