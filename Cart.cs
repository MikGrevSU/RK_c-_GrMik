namespace ShoppingCart
{
    public class Cart
    {
        public List<Product> Products { get; set; }
        private ITotalStrategy _strategy;

        public Cart(ITotalStrategy strategy)
        {
            Products = new List<Product>();
            _strategy = strategy;
        }

        public void SetStrategy(ITotalStrategy strategy)
        {
            _strategy = strategy;
        }

        public double GetTotal()
        {
            return _strategy.CalculateTotal(Products);
        }
    }
}
