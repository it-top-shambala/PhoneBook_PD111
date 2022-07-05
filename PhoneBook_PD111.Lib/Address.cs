namespace PhoneBook_PD111.Lib;

public class Address
{
    public string Type { get; set; }
    public string Country { get; set; }
    public string Region { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string Build { get; set; }

    public Address()
    {
    }

    public Address(string type, string country, string region, string city, string street, string build)
    {
        Type = type;
        Country = country;
        Region = region;
        City = city;
        Street = street;
        Build = build;
    }
}
