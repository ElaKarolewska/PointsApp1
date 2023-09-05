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
        public delegate void Added100PointsDelegate(object sender, EventArgs args);
        
        public abstract event Added100PointsDelegate Added100Points;
        public CustomerBase(string name, string surname) 
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get;  set; }
        public string Surname { get; set; }

        public abstract void AddPoint(char point);
        public abstract void AddPoint (string point);
        public abstract void AddPoint(int point);
        
        public abstract Statistics GetStatistics();
       
        public void ShowStatistics()
        {
            var statistics= GetStatistics();

            Console.WriteLine($"{Name} {Surname} statistics:");
            Console.WriteLine($"Total points {statistics.Sum}:");
            Console.WriteLine($"Min {statistics.Min}:");
            Console.WriteLine($"Max {statistics.Max}:");
            Console.WriteLine($"Average {statistics.Average:N2}:");
            
        }
    }
}
