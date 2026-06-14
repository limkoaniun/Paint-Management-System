namespace Paint_Management_System;

public class Order
{
    public readonly DateTime CreatedAt;
    public List<PaintProduct> Products { get; }


    public Order(List<PaintProduct> products)
    {
        Products = products;
        CreatedAt = DateTime.Now;
    }

    public void DisplayOrder()
    {
        Console.WriteLine($"Order created at: {CreatedAt}");
        foreach (var product in Products)
        {
            product.DisplayInfo();
            Console.WriteLine();
        }

        Console.WriteLine($"Order Total: {GetTotalOrderPrice():C}");
    }


    public decimal GetTotalOrderPrice()
    {
        var total = Products.Sum(p => p.GetFinalPrice());
        return total;
    }
}