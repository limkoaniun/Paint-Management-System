namespace Paint_Management_System;

public class Program
{
    public static void Main(string[] args)
    {
        var brand1 = new Brand("Dulux", "UK");
        var brand2 = new Brand("Nippon", "Japan");
        var spec1 = new PaintSpecification("White", 4);
        var product1 = new PaintProduct("Premium White", PaintType.Matte, spec1, 100m, 0.10m, brand1);
        var spec2 = new PaintSpecification("Black", 10);
        var product2 = new PaintProduct("Glossy Black", PaintType.Glossy, spec2, 150m, 0.10m, brand2);
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

        var order = new Order(2, product1);
        order.DisplayOrder();
    }
}