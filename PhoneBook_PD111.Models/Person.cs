using PhoneBook_PD111.Models.Phones;

namespace PhoneBook_PD111.Models;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public List<string> Groups { get; init; }
    public List<Phone> Phones { get; init; }
    public List<Address> Addresses { get; init; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;

        Groups = new List<string>();
        Phones = new List<Phone>();
        Addresses = new List<Address>();
    }

    public Person()
    {
        Groups = new List<string>();
        Phones = new List<Phone>();
        Addresses = new List<Address>();
    }
}
