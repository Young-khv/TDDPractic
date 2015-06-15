using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental;

namespace VideoRentalTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public static void RentaCalculatorDebit()
        {
            Movie movie = new Movie(rentalPrice: 2);
            Rental rental = new Rental(movie, days: 6);
            Assert.AreEqual(rental.CalculateDebit(), 12);
        }
    }
}
