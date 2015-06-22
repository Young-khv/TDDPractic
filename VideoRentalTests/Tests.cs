using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental;

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
        public static RegularMovie movie;
        [SetUp]
        public static void SetUp()
        {
            movie = new RegularMovie(name: "TestMovie");
        }

        [Test]
        public static void RentaCalculatorDebit()
        {
            int days = 6;

            Rental rental = new Rental(movie, days: days);
            Assert.AreEqual(rental.CalculateDebit(), rental.Movie.RentalPrice * rental.Days);
        }

        [Test]
        public static void RentalAddRentalDays()
        {
            Rental rental = new Rental(movie, days: 6);
            rental.AddRentalDays();
            Assert.AreEqual(rental.CalculateDebit(), 2 * 7);
            rental.AddRentalDays(2);
            Assert.AreEqual(rental.CalculateDebit(), 2 * 9);
        }

        [Test]
        public static void RentalSubstractRentalDays()
        {
            Rental rental = new Rental(movie, days: 6);
            rental.SubstractRentalDays();
            Assert.AreEqual(rental.CalculateDebit(), 2 * 5);
            rental.SubstractRentalDays(2);
            Assert.AreEqual(rental.CalculateDebit(), 2 * 3);
        }

        [Test]
        public static void ExpectedRentalDaysException()
        {
            try
            {
                Rental rental = new Rental(movie, days: 6);
                rental.SubstractRentalDays(7);
                Assert.Fail();
            }
            catch (RentalDaysException e)
            {
                Assert.AreEqual(e.Days, -1);
            }

            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [Test]
        public static void ExpectedRentalDaysExceptionConstructor()
        {
            try
            {
                Rental rental = new Rental(movie, days: -6);
                Assert.Fail();
            }
            catch (RentalDaysException e)
            {
                Assert.AreEqual(e.Days, -6);
            }

            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}
