using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoRental
{
    public class RegularMovie
    {
        private double rentalPrice;
        private string name;

        public double RentalPrice { get { return rentalPrice; } }
        public string Name { get { return name; } }

        public RegularMovie(string name)
        {
            // TODO: Complete member initialization
            this.name = name;
            this.rentalPrice = 2;
        }
    }
}
