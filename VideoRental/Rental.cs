﻿using System;
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
            // TODO: Complete member initialization
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
            this.days -= days;
        }
    }
}
