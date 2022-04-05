using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Hotel
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != null)
                {
                    _name = value;
                }
            }
        }
        private Room[] Rooms;
        public void AddRoom(Room room)
        {
            Array.Resize(ref Rooms, Rooms.Length + 1);
            Rooms[^1] = room;
        }
        public void MakeReservation(int? roomNumber)
        {
            foreach (var item in Rooms)
            {
                if (item.Id == roomNumber)
                {
                    if (item.IsAvailable)
                    {
                        Console.WriteLine("rezerv olundu");
                        item.IsAvailable = false;
                    }
                    else
                    {
                        Console.WriteLine("otaq rezerv olunub");
                    }
                }
                else
                {
                    throw new NotAvailableException(message:"gdsh");
                }
            }
        }
        public Room this[int index]
        {
            get
            {
                if (index > 0 && Rooms.Length > 0)
                {
                    return Rooms[index];
                }
                else
                {
                    throw new NotAvailableException(message:"gdhs");
                }
            }
            set
            {
                if (index != null)
                {

                }
            }
        }
        public Hotel(string name, params Room[] rooms)
        {
            Name = name;
            Rooms = rooms;
        }
    }
}
