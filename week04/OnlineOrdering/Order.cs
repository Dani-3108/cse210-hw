using System.Net.Http.Headers;

public class Order
{
    //Attributes
    private List<Product> _productsList = new List<Product>();
    private Customer _customer;
    //Constructor
    public Order(List<Product> product, Customer customer)
    {
        _productsList = product;
        _customer = customer;
    }
    //Methods
    public double GetTotalCost()
    {
        double subTotal = 0;
        foreach (Product product in _productsList)
        {
            subTotal += product.GetTotalCost();
        }
        if (_customer.IsInUSA())
        {
            return subTotal + 5;
        }
        else
        {
            return subTotal + 35;
        }
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _productsList)
        {
            packingLabel += $"{product.GetName()},{product.GetProductId()}.\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}, {_customer.GetAddress().GetFullAddress()}";
    }
}