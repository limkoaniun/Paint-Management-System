using Paint_Management_System.Enums;

namespace Paint_Management_System.Models;

public class Order
{
    public readonly DateTime CreatedAt;


    public Order(List<PaintProduct> products)
    {
        Products = products;
        CreatedAt = DateTime.Now;
    }

    public List<PaintProduct> Products { get; }

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

    public PaintProduct GetMostExpensivePaintProduct()
    {
        return Products.MaxBy(p => p.Price);
    }

    public void RemoveProduct(int productId)
    {
        Products.RemoveAll(p => p.ProductId == productId);
    }

    public List<PaintProduct> GetProductsInPriceRange(decimal min, decimal max)
    {
        return Products.Where(p => p.Price > min && p.Price < max).ToList();
    }

    public Dictionary<PaintType, decimal> GetTotalPriceByType()
    {
        return Products
            .GroupBy(p => p.Type)
            .ToDictionary(group => group.Key,
                group => group.Sum(p => p.GetFinalPrice())
            );
    }
}