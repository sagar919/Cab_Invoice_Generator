using System;

namespace CabInvoiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();

            double fare = invoiceGenerator.CalculateFare(10, 5);
            Console.WriteLine(fare);

            //Ride[] rides = new Ride[3] { new Ride(10.0, 2), new Ride(12.0, 5), new Ride(13.0, 6) };
            //for (int i = 0; i < rides.Length; i++)
            //{
            //    Console.WriteLine("Enter distance");
            //    rides[i].distance = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Enter time");
            //    rides[i].time = Convert.ToInt32(Console.ReadLine());
            //}

            //Ride[] rides = new Ride[2];
            //for (int i = 0; i < rides.Length; i++)
            //{
            //    Console.WriteLine("Enter distance");
            //    double distance = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Enter time");
            //    int time = Convert.ToInt32(Console.ReadLine());
            //    rides[i] = new Ride(distance, time);
            //}

            //double fare2 = invoiceGenerator.CalculateFare(rides);
            //Console.WriteLine(fare2);
        }
    }
}
