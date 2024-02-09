namespace Basket.API.Entities
{
    public class Basket(string userName)
    {
        public string UserName { get; set; } = userName;
        public List<BasketIem> Items { get; set; }
        public string State { get; set; }

        public decimal TotalPrice
        {
            get
            {
                return Items.Sum(p => p.Price);
            }
        }
    }
}
