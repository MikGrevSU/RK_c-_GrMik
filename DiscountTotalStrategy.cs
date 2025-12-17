namespace ShoppingCart
{
    public class DiscountTotalStrategy : ITotalStrategy
    {
        private double _discount; 

        public DiscountTotalStrategy(double discount)
        {
            _discount = discount;
        }

        public double CalculateTotal(List<Product> products)
        {
            double total = 0;
            foreach (var p in products)
                total += p.Price;
            return total * (1 - _discount / 100);
        }
    }
}
