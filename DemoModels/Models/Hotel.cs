using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoModels.Models
{
    public class Hotel
    {
        public int IDHotel { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Rating { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string  Currency { get; set; }
        public int MaxPersons { get; set; }
        public int MaxChildren { get; set; }
        public decimal PricePerNight { get; set; }
        public bool IsBooked { get; set; }
        
        public Hotel(int idHotel, string name, string location, int rating, double latitude, double longitude, string currency, 
                     int maxPersons, int maxChildren, decimal priceperNight)
        {
            IDHotel = idHotel;
            Name = name;
            Location = location;
            Rating = rating;
            Latitude = latitude;
            Longitude = longitude;
            Currency = currency;
            MaxPersons = maxPersons;
            MaxChildren = maxChildren;
            PricePerNight = priceperNight;
            IsBooked = false;
         

        }

        public void HotelLongitude(double longitude)
        {
            Longitude = longitude;
        }

        public void HotelLatitude(double latiude)
        {
            Latitude = latiude;
        }
        public void Book()
        {
            IsBooked = true;
        }

        public void Unbook()
        {
            IsBooked = false;
        }

    }
}
