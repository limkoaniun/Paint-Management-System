namespace Paint_Management_System;

public class PaintProduct : IBuyable
{
    public const decimal DefaultDiscount = 0.05m;
    public readonly decimal TaxRate;

    public PaintProduct(string name, PaintType type, PaintSpecification specification, decimal price, decimal taxRate,
        Brand brand)
    {
        Name = name;
        Type = type;
        Specification = specification;
        Price = price;
        TaxRate = taxRate;
        Brand = brand;
    }

    public string Name { get; }
    public PaintType Type { get; }
    public PaintSpecification Specification { get; }
    public decimal Price { get; }

    public Brand Brand { get; }

    public decimal GetFinalPrice()
    {
        return Price * (1 - DefaultDiscount) * (1 + TaxRate);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Type: {Type}");
        Console.WriteLine($"Price: {Price:C}, Final Price: {GetFinalPrice():C}");
        Console.WriteLine($"Name: {Name}, Brand: {Brand.Name}, Type: {Type}");
        Specification.DisplaySpecification();
    }

    public decimal GetMaxDiscount(int rate, bool isOverridable)
    {
        if (isOverridable) return rate / 100m;

        return DefaultDiscount;
    }
}