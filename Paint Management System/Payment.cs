namespace Paint_Management_System;

public class Payment
{
   public int PaymentId { get; }
   public Order Order { get; }
   public PaymentStatus PaymentStatus { get; }
   public PaymentMethod PaymentMethod { get; }
   public User User { get; }
   public decimal PaymentAmount { get; }
   public DateTime CreatedAt { get; }

   public Payment(int paymentId, Order order, PaymentStatus paymentStatus, PaymentMethod paymentMethod, User user, decimal paymentAmount)
   {
      PaymentAmount = paymentAmount;
      PaymentId = paymentId;
      Order = order;   
      PaymentStatus = paymentStatus;
      PaymentMethod = paymentMethod;
      User = user;
      CreatedAt = DateTime.Now;
   }
}