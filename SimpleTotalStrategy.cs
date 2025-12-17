namespace ShoppingCart
{
    public class SimpleTotalStrategy : ITotalStrategy
    {
        public double CalculateTotal(List<Product> products)
        {
            double total = 0;
            foreach (var p in products)
                total += p.Price;
            return total;
        }
    }
}
