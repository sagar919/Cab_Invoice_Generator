using NUnit.Framework;
using CabInvoiceGenerator;

namespace CabInvoiceTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenDistanceAndTime_ShouldReturnTotalFare()
        {
            //Arrange
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double distance = 3;
            int time = 10;

            //Act
            double fare = invoiceGenerator.CalculateFare(distance, time);

            //Assert
            Assert.AreEqual(40, fare);

        }

        [Test]
        public void GivenLessDistanceAndTime_ShouldReturnMinimumFare()
        {
            //Arrange
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double distance = 0.2;
            int time = 2;

            //Act
            double fare = invoiceGenerator.CalculateFare(distance, time);

            //Assert
            Assert.AreEqual(5, fare);

        }

        [Test]
        public void GivenMultipleRides_ShouldReturnTotalFare()
        {   //Arrange
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            Ride[] rides = { new Ride(2.0, 5),new Ride(0.1, 1)};
            InvoiceSummary invoiceSummary = invoiceGenerator.CalculateFare(rides);
            double expected = 30;
            Assert.AreEqual(expected, invoiceSummary.TotalFare);
        }
    }
}