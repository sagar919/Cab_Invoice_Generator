using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        private static readonly int costPerMinute = 1;
        private static readonly int minimumCostPerKilometer = 10;
        private static readonly int minimumFare = 5;

        public double CalculateFare(double distance,int time)
        {
            double totalFare = distance * minimumCostPerKilometer + time * costPerMinute;
            if(totalFare < minimumFare)
            {
                return minimumFare;
            }
            return totalFare;

        }

        public InvoiceSummary CalculateFare(Ride[] rides)
        {
            double totalFare = 0;
            int TotalNumberOfRides = 0;
            
            InvoiceSummary invoiceSummary = new InvoiceSummary();
            foreach (Ride ride in rides)
            {
                totalFare += this.CalculateFare(ride.distance, ride.time);
                TotalNumberOfRides++;
            }
            invoiceSummary.TotalNumberOfRides = TotalNumberOfRides;
            invoiceSummary.TotalFare = totalFare;
            invoiceSummary.CalculateAvergaeFare();
            return invoiceSummary;


        }   

       
    }
}
