using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hotel room = new Hotel();
            //room.MakeReservation(3);
            //try
            //{
            //    Room[] rooms= { };
            //    for (int i = 0; i < rooms.Length; i++)
            //    {
            //        room.
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            Room room1 = new Room();
            Room room2 = new Room();
            Hotel hotel = new Hotel("f",room1, room2);
            hotel.MakeReservation(2);
            Console.WriteLine(hotel[0]);

        }
    }
}
