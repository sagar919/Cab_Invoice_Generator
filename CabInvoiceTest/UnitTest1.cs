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
            double fare = invoiceGenerator.CalculateFare(distance,time);

            //Assert
            Assert.AreEqual(40, fare);




        }
    }
}