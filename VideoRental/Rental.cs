using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoRental
{
    public class Rental
    {
        private RegularMovie regularMovie;
        private int days;

        public RegularMovie Movie { get { return regularMovie; } }

        public int Days
        {
            get { return days; }
            private set
            {
                if (value < 0)
                    throw new RentalDaysException(value);
                days = value;
            }
        }
        public Rental(RegularMovie regularMovie, int days)
        {
            if (regularMovie == null)
                throw new ArgumentNullException("regularMovie");
            this.regularMovie = regularMovie;
            this.Days = days;
        }

        public double CalculateDebit()
        {
            return Days * regularMovie.RentalPrice;
        }

        public void AddRentalDays(int days = 1)
        {
            this.Days += days;
        }

        public void SubstractRentalDays(int days = 1)
        {
            int daysAfterSubstruct = this.days - days;

            this.Days = daysAfterSubstruct;
        }
    }
}
