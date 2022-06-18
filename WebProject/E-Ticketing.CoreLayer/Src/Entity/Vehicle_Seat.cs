using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.Entity
{
    public class Vehicle_Seat
    {
        public readonly string SeatStatusBooked="Booked";
        public readonly string SeatStatusAvailable = "Available";

        protected Vehicle_Seat( )
        {
           
        
        }
       
        public Vehicle_Seat(string seat_Number, Vehicle vehicle)
        {
            Seat_Number = seat_Number;
            SeatStatus = SeatStatusAvailable;
            VehicleId = vehicle.Id;
            Vehicle = vehicle;
        }
        public virtual int Id { get; protected set; }
        public virtual string Seat_Number { get; protected set; }  
        public virtual string SeatStatus { get; protected set; }
        public virtual int VehicleId { get; protected set; }
        public virtual Vehicle Vehicle { get; protected set; }
        public Boolean IsAvailable()
        {
            return SeatStatus == SeatStatusAvailable;
        }

        public void BookVehicleSeat()
        {
            SeatStatus = SeatStatusBooked;
        }
    }
}
