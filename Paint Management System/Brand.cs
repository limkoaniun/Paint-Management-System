namespace Paint_Management_System;

public class Brand
{
    public string Name { get; }
    public string Country { get; }

    public Brand(string name, string country)
    {
        Name = name;
        Country = country;
    }
}