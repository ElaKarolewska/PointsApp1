using PointsApp1;

namespace PointsAppTests
{
    public class Tests
    {

        [Test]
        public void GetCustomerReturnDifferentObjects()
        {
            var customer1 = GetCustomer("Ela" ,"Karolewska");
            var customer2 = GetCustomer("Adam", "Karolewski");
           
            Assert.AreNotEqual(customer1, customer2);
        }

        [Test]
        public void MinValueTest() 
        {
            var customer = new CustomerInMemory("Ela", "Karolewska");
            customer.AddPoint(40);
            customer.AddPoint(80);
            customer.AddPoint(5);

            Statistics statistics = customer.GetStatistics();

            Assert.AreEqual(5, statistics.Min);
        
        }
        
        private CustomerInMemory GetCustomer(string name, string surname)
        {
            return new CustomerInMemory(name, surname);
        }
    }
}