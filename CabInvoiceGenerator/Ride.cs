using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class Ride
    {
        public double distance;
        public int time;

        public Ride(double Distance, int Time)
        {
            this.distance = Distance;
            this.time = Time;
        }
    }
}
