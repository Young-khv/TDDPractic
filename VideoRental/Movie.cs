using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoRental
{
    public class Movie
    {
        private double rentalPrice;

        public double RentalPrice { get { return rentalPrice; } }

        public Movie(double rentalPrice)
        {
            // TODO: Complete member initialization
            this.rentalPrice = rentalPrice;
        }
    }
}
