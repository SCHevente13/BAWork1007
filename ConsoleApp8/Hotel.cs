using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal record Hotel(string Name, string City, string Category, string Owner, int TotalRooms)
    {
        private string _owner { get; init; } = Owner;
        public int PricePerNight { get; set; }
        public double Rating { get; set; }
        private int _availableRooms { get; set; }
        private int _totalRooms { get; init; } = TotalRooms;
        public int GetPrice()
        {
            return PricePerNight;
        }
        public double GetRating()
        {
            return Rating;
        }
        public int GetAvailableRooms()
        {
            return _availableRooms;
        }
        public string GetOwner()
        {
            return _owner;
        }


    }
}
