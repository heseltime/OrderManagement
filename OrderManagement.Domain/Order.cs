namespace OrderManagement.Domain;

public class Order
{
    public Order(Guid id, string article, DateTimeOffset orderDate, decimal totalPrice)
    {
        Id = id;
        OrderDate = orderDate;
        Article = article ?? throw new ArgumentNullException(nameof(article));
        TotalPrice = totalPrice;
    }

    public Guid Id { get; set; }

    public string Article { get; set; }

    public DateTimeOffset OrderDate { get; set; }

    public decimal TotalPrice { get; set; }

    public Customer? Customer { get; set; }
}
