using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoRental
{
    public class Movie
    {
        private int rentalPrice;

        public int RentalPrice { get { return rentalPrice; } }

        public Movie(int rentalPrice)
        {
            // TODO: Complete member initialization
            this.rentalPrice = rentalPrice;
        }
    }
}
