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
            double rentalPrice = 2;
            int days = 6;
            Movie movie = new Movie(rentalPrice: rentalPrice);
            Rental rental = new Rental(movie, days: days);
            Assert.AreEqual(rental.CalculateDebit(), days * rentalPrice);
        }

        [Test]
        public static void RentalAddRentalDays()
        {

            Rental rental = new Rental(new Movie(rentalPrice: 2), days: 6);
            rental.AddRentalDays();
            Assert.AreEqual(rental.CalculateDebit(), 2 * 7);
            rental.AddRentalDays(2);
            Assert.AreEqual(rental.CalculateDebit(), 2 * 9);
        }
    }
}
