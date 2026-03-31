public class Customer
{
    //Attributes
    private string _name;
    private Address _address;
    //Cosntructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    //Methods
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }
    public string GetName()
    {
        return _name;
    }
    public Address GetAddress()
    {
        return _address;
    }
}