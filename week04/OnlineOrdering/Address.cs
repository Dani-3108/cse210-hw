public class Address
{
    //Attributes
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;
    //Constructor 
    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateProvince = state;
        _country = country;
    }
    //Methods
    public bool IsInUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}\n{_stateProvince}\n{_country}";
    }
}