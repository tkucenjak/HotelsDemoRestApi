using DemoModels.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        [HttpGet]
        [Route("GetHotels")]
        public IActionResult GetHotels(double? Latitude, double? Longitude, int? NoOfHotels)
        {
            if (NoOfHotels == null) NoOfHotels = 3;


            List<Hotel> hotels = new List<Hotel>()
            {
                new Hotel(1, "DoubleTree by Hilton Zagreb", "ZAGREB", 5,45.8022273672354, 16.00157983404579, "€",3,2,98),
                new Hotel(2, "The Westin Zagreb", "ZAGREB", 4,45.80710436493705, 15.96613425255562, "€", 5,2,120),
                new Hotel(3, "Garden Hotel", "ZAGREB", 4,45.8057282457636, 15.96776503550422, "€", 4,3,150),
                new Hotel(4, "Hotel International", "ZAGREB", 3,45.79956520811419, 15.974331082639383, "€", 4,2,113),
                new Hotel(5, "Hotel Jadran", "ZAGREB", 4,45.81405971886179, 15.984684959940887, "€", 3,2,75),
                new Hotel(5, "Hotel Panorama", "ZAGREB", 4,46.32453095155191, 16.610922794311513, "€", 3,2,111),


            };

            if (Latitude > 0 && Longitude > 0)
            {
                List<Hotel> nearestHotels = new List<Hotel>();
                List<double> distances = new List<double>();
                foreach (var hotel in hotels)
                {
                    var distance = GeoLocation.CalculateDistance((double) Latitude, (double)Longitude, hotel.Latitude, hotel.Longitude);
                    distances.Add(distance);
                }

                var sortedDistances = distances.OrderBy(x => x).ToList();
                for (int i = 0; i < NoOfHotels; i++)
                {
                    var nearestHotel = hotels[distances.IndexOf(sortedDistances[i])];
                    nearestHotels.Add(nearestHotel);
                }

                return Ok(nearestHotels);
            }
            else
            {
                return Ok(hotels);
            }

       
           

        }
        

    }
}
