namespace Paint_Management_System;

public class Program
{
    public static void Main(string[] args)
    {
        var brand1 = new Brand("Dulux", "UK");
        var brand2 = new Brand("Nippon", "Japan");
        var spec1 = new PaintSpecification("White", 4);
        var product1 = new PaintProduct("Premium White", 1, PaintType.Matte, spec1, 100m, 0.10m, brand1);
        var spec2 = new PaintSpecification("Black", 10);
        var product2 = new PaintProduct("Glossy Black", 2, PaintType.Glossy, spec2, 150m, 0.10m, brand2);
        var products = new List<PaintProduct>
        {
            product1,
            product2
        };

        foreach (var product in products)
        {
            product.DisplayInfo();
            Console.WriteLine();
        }

        var order = new Order(products);
        order.DisplayOrder();

        var inRange = order.GetProductsInPriceRange(90m, 200m);
        Console.WriteLine($"--- Products priced between $90 and $200 ({inRange.Count} found) ---");
        foreach (var p in inRange)
        {
            p.DisplayInfo();
            Console.WriteLine();
        }
        
        var totals = order.GetTotalPriceByType();
        Console.WriteLine("--- Total price by paint type ---");
        foreach (var pair in totals)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value:C}");
        }
    }
}