public class Order
{
    private List<Product> _productList;
    private Customer _consumer;

    public Order(List<Product> productList, Customer consumer)
    {
        _productList = productList;
        _consumer = consumer;
    }
    //methods
    public double TotalCost()
    {
        return 0.99; // welp
    }

    public string DisplayLabel()
    {
        return "";
    }
}