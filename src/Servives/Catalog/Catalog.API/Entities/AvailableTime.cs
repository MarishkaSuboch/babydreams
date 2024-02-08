namespace Catalog.API.Entities
{
    public record AvailableTime
    {
        public int Id { get; set; }
        public int ConsultantId { get; set; }
        public DateTime Date { get; set; }
        public TimeOnly Time { get; set; }
        public bool Available { get; set; }
    }
}
