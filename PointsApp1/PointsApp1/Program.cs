using System;

namespace PointsApp1
{

    internal class Program
    {

        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the application to service your customers' points.\n" + "");

            bool CloseApp = false;

            while (!CloseApp)
            {
                Console.WriteLine("1 - Add customer points to the program memory.\n" +
                                  "2 - Add customer points to the .txt file\n" +
                                  "X - Close app.\n");


                Console.WriteLine("What do you want to do?\n" + "Press 1, 2 or X.");
                var userInput = Console.ReadLine().ToUpper();

                switch (userInput)
                {

                    case "1":
                        AddPointsToMemory();
                        break;
                    case "2":
                        AddPointsToTheFile();
                        break;
                    case "X":
                        CloseApp = true;
                        break;

                    default:
                        Console.WriteLine("Invalid operation.\n");

                     continue;
                }

            }
            Console.WriteLine("Now you can press any key to leave.");
            Console.ReadKey();
        }



        static void Added100Points(object sender, EventArgs args) 
        {
            Console.WriteLine("Added 100 points, congratulations to the customer - now should receive a discount!");
        }

        private static void AddPointsToMemory()
        {
            
            Console.WriteLine("Please insert customer's name: ");
            var name = Console.ReadLine();
           
            Console.WriteLine("Please insert customer's surname: ");
            var surname = Console.ReadLine();
            
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname))
            {
                var inMemoryCustomer = new CustomerInMemory(name, surname);
                inMemoryCustomer.Added100Points += Added100Points;
                EnterPoint(inMemoryCustomer);
                inMemoryCustomer.ShowStatistics();
            }
            else
            {
                Console.WriteLine("Customer's name and surname can not be empty! ");
            }

        }
        private static void AddPointsToTheFile()
        {
            Console.WriteLine("Please insert customer's name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Please insert customer's surname: ");
            var surname = Console.ReadLine();

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname))
            {
                var inFileCustomer = new CustomerInFile(name, surname);
                inFileCustomer.Added100Points += Added100Points;
                EnterPoint(inFileCustomer);
                inFileCustomer.ShowStatistics();
            }
            else
            {
                Console.WriteLine("Customer's name and surname can not be empty! ");
            }
        }
        
        private static void EnterPoint(ICustomer customer)
        {
            while (true) 
            {
                Console.WriteLine($"Enter points for {customer.Name} {customer.Surname}:");
                var input = Console.ReadLine();

                if (input.ToLower() == "q") 
                {
                    break;
                }
                try
                {
                    customer.AddPoint(input);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception catched:{e.Message}");
                }
                finally 
                {
                    Console.WriteLine($"To leave and show {customer.Name} {customer.Surname} ststistics enter 'q'.");
                }
            }
        }
               
    }

}
















        
    
    


   
    











    