using System;

namespace Modio.Xamarin.UI.Models
{
    public class BookingSummary
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int HotelId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}