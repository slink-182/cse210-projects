using System.Numerics;

public class Order
{
    private List<Product> _productList = new List<Product>();
    private Customer _consumer;

    public Order(List<Product> productList, Customer consumer)
    {
        _productList = productList;
        _consumer = consumer;
        
    }

    //methods
    public float FinalTotalCost()
    {
        float _outUS = 35;
        float _isUS = 5;
        float _total = 0;

        foreach (Product p in _productList)
        {
            _total += p.TotalCost();
        }

        if (_consumer.IsAmerican())
        {
            return _total + _isUS;
        }
        else
        {
            return _total + _outUS;
        }
    }


    public string GetPackingLabel()
    {
        string label = "PACKING LABEL:\n";

        foreach (Product p in _productList)
        {
            label += $"{p.GetProductName()} (ID: {p.GetProductID()})\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return $"SHIPPING LABEL:\n{_consumer.GetName()}\n{_consumer.GetAddress().GetFullAddress()}";
    }
}