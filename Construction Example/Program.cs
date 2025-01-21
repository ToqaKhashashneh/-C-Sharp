

using System;

namespace Construction_Example
{
    class Hotel_Reservations
    {
        private int roomNumber { get; set; }
        private string roomType { get; set; }
        private double priceperNight { get; set; }
        private bool IsBooked { get; set; }
        public const string hotelname = "Grand Stay Hotel";
        //1) without parameters

        public Hotel_Reservations()
        {
            roomNumber = 20;
            roomType = "Single";
            priceperNight = 100;
            IsBooked = false;

        }

        //2) with parameters
        public Hotel_Reservations( int roomN ,string roomTy , double price ,bool IsBooked ) {

            roomNumber = roomN;
            roomType = roomTy;
            priceperNight = price;
            IsBooked = false;
        }
        ~Hotel_Reservations()
        {
            Console.WriteLine("Destructor Called");
        }




    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel_Reservations hotel = new Hotel_Reservations();
            Hotel_Reservations hotel =  new Hotel_Reservations(20, "Single", 100, false);
        }
    }
}
