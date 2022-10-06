using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservaHotel.Exceptions;

namespace ReservaHotel.Entities
{
  class Reservation
  {
    public int RoomNumber { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }

    public Reservation()
    {

    }

    public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
    {
      if (checkOut <= checkIn)
      {
        throw new DomainException("A data de check-out não pode ser menor que a data de check-in");
      }

      RoomNumber = roomNumber;
      CheckIn = checkIn;
      CheckOut = checkOut;
    }

    public int Duration()
    {
      TimeSpan duration = CheckOut.Subtract(CheckIn);
      return (int)duration.TotalDays;
    }

    public void UpdateReservationDates(DateTime checkIn, DateTime checkOut)
    {
      DateTime agora = DateTime.Now;

      if(checkIn < agora || checkOut < agora)
      {
        throw new DomainException( "As novas datas não pode ser anterior a data atual");
      }

      if(checkOut <= checkIn)
      {
        throw new DomainException( "A data de check-out não pode ser menor que a data de check-in");
      }
      CheckIn = checkIn;
      CheckOut = checkOut;

    }

    public override string ToString()
    {
      return $"Room {RoomNumber}, CheckIn: {CheckIn.ToString("dd/MM/yyyy")}, CheckOut: {CheckOut}, Duration: {Duration()} nigths. ";
    }
  }
}
