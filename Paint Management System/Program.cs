using Paint_Management_System.Enums;
using Paint_Management_System.Models;

namespace Paint_Management_System;

public class Program
{
    public static void Main(string[] args)
    {
        var brand1 = new Brand("Dulux", "UK");
        var brand2 = new Brand("Nippon", "Japan");
        var spec1 = new PaintSpecification("White", 4);
        var product1 = new PaintProduct("Premium White", 1, PaintType.Matte, spec1, 100m, 0.1m, brand1);
        var spec2 = new PaintSpecification("Black", 10);
        var product2 = new PaintProduct("Glossy Black", 2, PaintType.Glossy, spec2, 150m, 0.1m, brand2);
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
        foreach (var pair in totals) Console.WriteLine($"{pair.Key}: {pair.Value:C}");

        var user = new User(1, "Koan");
        var order2 = new Order(new List<PaintProduct> { product2 });
        user.Orders.Add(order);
        user.Orders.Add(order2);
        var payment1 = new Payment(1, order, PaymentStatus.Success, PaymentMethod.Alipay, user, 104.5m);
        var payment2 = new Payment(2, order2, PaymentStatus.Pending, PaymentMethod.CreditCard, user, 8m);
        user.Payments.Add(payment1);
        user.Payments.Add(payment2);
        
        Console.WriteLine($"Most expensive order total: {user.GetMostExpensiveOrder().GetTotalOrderPrice():C}");
        Console.WriteLine($"Latest order created at: {user.GetLatestOrder().CreatedAt}");
        Console.WriteLine($"Lowest payment: {user.GetLowestPayment().PaymentAmount:C}");
        Console.WriteLine($"Latest payment id: {user.GetLatestPayment().PaymentId}");

        var bigPayments = user.GetPaymentsOver(10m);
        Console.WriteLine($"Payments over $10: {bigPayments.Count}");
    }
}