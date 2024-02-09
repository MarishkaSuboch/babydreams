namespace Basket.API.Entities
{
    public record BasketIem
    {
        public string ProductId { get; set; } 
        public string ProductName { get; set; }
        public string ConsultantName { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        public string Currency { get; set; }
    }
}
