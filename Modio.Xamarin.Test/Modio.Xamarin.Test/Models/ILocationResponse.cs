﻿using System;
using System.Globalization;

namespace Modio.Xamarin.UI.Models
{
    public interface ILocationResponse
    {
    }

    public class GeoLocation : ILocationResponse
    {
        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public static GeoLocation Parse(string location)
        {
            GeoLocation result = new GeoLocation();

            try
            {
                //var locationSetting = AppSettings.DefaultFallbackMapsLocation;
                var locationSetting = "";
                var locationParts = locationSetting.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);

                result.Latitude = double.Parse(locationParts[0], CultureInfo.InvariantCulture);
                result.Longitude = double.Parse(locationParts[1], CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error parsing location: {ex}");
            }

            return result;
        }
    }
}