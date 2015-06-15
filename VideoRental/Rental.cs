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
        public int Days { get { return days; }
            private set 
            {
                if(value < 0)
                    throw new RentalDaysException(value);
                days = value;
            }
        }
        public Rental(Movie movie, int days)
        {
            if (movie == null)
                throw new ArgumentNullException("movie");          
            this.movie = movie;
            this.Days = days;
        }

        public double CalculateDebit()
        {
            return Days * movie.RentalPrice;
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
