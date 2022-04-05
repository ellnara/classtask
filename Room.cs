using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class Room
    {
        public int Id;
        private static int _id;
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
        private int _price { get; set; }
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value != 0)
                {
                    _price = value;
                }
            }
        }
        private int _person_capasity { get; set; }
        public int PersonCapasity
        {
            get
            {
                return _person_capasity;
            }
            set
            {
                if (value != 0)
                {
                    _person_capasity = value;
                }
            }
        }
        public Room()
        {
            _id++;
            Id = _id;
        }
        public bool IsAvailable = true;
        public string ShowInfo()
        {
            string  info = "Id" + Id+ "Name: " + Name + "Price: "+ Price + "PersonCapasity: "+ PersonCapasity + "Is Available: " + IsAvailable;
            return info; 
        }
        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
