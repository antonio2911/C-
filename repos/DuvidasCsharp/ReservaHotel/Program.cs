using ReservaHotel.Entities;
using ReservaHotel.Exceptions;
using System;

namespace ReservaHotel
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        Console.WriteLine("Room Number");
        int number = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Check-In date (dd/MM/yyyy)");
        DateTime checkIn = DateTime.Parse(Console.ReadLine());
        
        Console.WriteLine("Check-Out date (dd/MM/yyyy)");
        DateTime checkOut = DateTime.Parse(Console.ReadLine());
        
        Reservation reserva = new Reservation(number, checkIn, checkOut);
        
        Console.WriteLine(reserva);
        
        Console.WriteLine("Deseja atualizar a reservar? s/n");
        
        char confirmacao = char.Parse(Console.ReadLine());

        if (confirmacao == 's')
        {
          checkIn = DateTime.Parse(Console.ReadLine());
          checkOut = DateTime.Parse(Console.ReadLine());
          reserva.UpdateReservationDates(checkIn, checkOut);
        }

      }
      catch (DomainException e)
      {
        Console.WriteLine($"Erro ao reservar! {e.Message}");
      }
      catch(FormatException e)
      {
        Console.WriteLine($"Format Erro {e.Message}");
      }
      catch(Exception e)
      {
        Console.WriteLine($"Erro inesperado {e.Message}");
      }
    }
    }
  }
