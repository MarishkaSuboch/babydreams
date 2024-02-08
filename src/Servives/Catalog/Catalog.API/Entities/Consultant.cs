using System.Globalization;

namespace Catalog.API.Entities
{
    public record Consultant
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Social { get; set; }
        public string Description { get; set; }
        public TimeOnly WorkTineFrom { get; set; } 
        public TimeOnly WorkTineTo { get; set; }
        public TimeZoneInfo TimeZone { get; set; }
    }
}
