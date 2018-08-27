using System;
using System.Collections.Generic;

namespace TravelTime
{
    public class Activity : Location
    {
        public double Price {get; set;}
        public int Duration {get; set;}
        public int MaxiumumGuests {get; set;}
        public string HoursOperation { get; set;}

        public string Register (
            Tourist registrar,
            int guests,
            DateTime day,
            PaymentTypes payment)
            {
                
            }
    }
}