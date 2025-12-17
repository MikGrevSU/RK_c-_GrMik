namespace ShoppingCart
{
    public interface ITotalStrategy
    {
        double CalculateTotal(List<Product> products);
    }
}
