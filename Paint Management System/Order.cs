namespace Paint_Management_System;

public class Order
{
    public readonly DateTime CreatedAt;

    public PaintProduct Product { get; }

    public int Quantity { get; }

    public decimal TotalPrice { get; }

    public Order(int quantity, PaintProduct product)
    {
        Quantity = quantity;
        Product = product;
        CreatedAt = DateTime.Now;
        TotalPrice = product.GetFinalPrice() * quantity;
    }

    public void DisplayOrder()
    {
        Console.WriteLine($"Order created at: {CreatedAt}", $"Quantity: {Quantity}", $"Total: {TotalPrice:C}.");
        Product.DisplayInfo();
    }

    public decimal GetTotalPrice()
    {
        return TotalPrice;
    }
}