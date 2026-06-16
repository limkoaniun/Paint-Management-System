namespace Paint_Management_System.Models;

public class Brand
{
    public Brand(string name, string country)
    {
        Name = name;
        Country = country;
    }

    public string Name { get; }
    public string Country { get; }
}