using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoRental
{
    public class Rental
    {
        private Movie movie;
        private int days;

        public Rental(Movie movie, int days)
        {
            if (movie == null)
                throw new ArgumentNullException("movie");
            if (days < 0)
                throw new RentalDaysException(days);
            this.movie = movie;
            this.days = days;
        }

        public double CalculateDebit()
        {
            return days * movie.RentalPrice;
        }        

        public void AddRentalDays(int days = 1)
        {
            this.days += days;
        }

        public void SubstractRentalDays(int days = 1)
        {
            int daysAfterSubstruct = this.days - days;
            if (daysAfterSubstruct < 0)
            {
                throw new RentalDaysException(daysAfterSubstruct);
            }

            this.days = daysAfterSubstruct;
        }
    }
}
