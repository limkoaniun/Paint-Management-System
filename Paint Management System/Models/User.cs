namespace Paint_Management_System.Models;

public class User
{
    public int UserId { get; }
    public string Name { get; }
    public List<Payment> Payments { get; }
    public List<Order> Orders { get; }

    public User(int userId, string name)
    {
        UserId = userId;
        Name = name;
        Orders = new List<Order>();
        Payments = new List<Payment>();
    }

    public Order GetMostExpensiveOrder()
    {
        return Orders.MaxBy(order => order.GetTotalOrderPrice());
    }

    public Order GetLatestOrder()
    {
        return Orders.MaxBy(order => order.CreatedAt);
    }

    public Payment GetLowestPayment()
    {
        return Payments.MinBy(p => p.PaymentAmount);
    }

    public Payment GetLatestPayment()
    {
        return Payments.MaxBy(p => p.CreatedAt);
    }

    public List<Payment> GetPaymentsOver(decimal amount)
    {
        return Payments.Where(p => p.PaymentAmount > amount)
            .OrderByDescending(p => p.PaymentAmount)
            .ToList();
    }
}