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
    }
}
