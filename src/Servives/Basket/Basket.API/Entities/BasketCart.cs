namespace Basket.API.Entities
{
    public class BasketCart
    {
        public BasketCart(string userName)
        {
            UserName = userName;
        }
        public string UserName { get; set; }
        public List<BasketIem> Items { get; set; }
        public string State { get; set; }

        //TODO if there are no Items
        public decimal TotalPrice
        {
            get
            {
                return Items.Sum(p => p.Price);
            }
        }
    }
}
