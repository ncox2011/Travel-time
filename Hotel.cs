using System;
using System.Collections.Generic;


namespace TravelTime
{

    public enum PaymentTypes
    {
        Cash,
        Visa,
        Mastercard,
        Discover,
        Bitcoin
    }

    public class Hotel : Location
    {


        public double RoomPrice { get; set; }
        public int Rating { get; set; }
        public int MaxiumumOccupancy { get; set; }
        public int CheckIn(Tourist guest, PaymentTypes payment)
        {
            return 1;
        }

        public string MakeReservation(
            Tourist guest,
            PaymentTypes payment,
            DateTime checkIn,
            DateTime checkOut,
            int guestCount
        )
        {
            return "fdklsakjfeifoljkfkdkslei";
        }

        public Dictionary<string, string> RegisterComplaints(string complaint)
        {
            Dictionary<string, string> response = new Dictionary<string, string>();
            response["feedback"] = "Thank you for your feedback.. We value your business.";
            response["offer"] = "";

            return response;
        }
        public Dictionary<string, string> RegisterComplaints(string complaint, string email)
        {
            Dictionary<string, string> response = new Dictionary<string, string>();
            response["feedback"] = "Thank you for your feedback.. We value your business.";
            response["offer"] = "One free night! Use before January 1, 2018.";

            return response;
        }


    }
}