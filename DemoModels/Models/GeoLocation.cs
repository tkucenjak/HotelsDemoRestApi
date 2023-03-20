using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoModels.Models;

namespace DemoModels.Models
{   public partial class GeoLocation 
        {

            protected double Longitude { get; set; }
            protected double Latitude { get; set; }

            private const double EarthRadius = 6371; // km
            public static double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
            {
                var dLat = (lat2 - lat1) * Math.PI / 180;
                var dLon = (lon2 - lon1) * Math.PI / 180;
                var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Cos(lat1 * Math.PI / 180) * Math.Cos(lat2 * Math.PI / 180) *
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
                var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
                var distance = EarthRadius * c;
                return distance;
            }
        }


    }


