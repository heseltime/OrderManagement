using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace OrderManagement.Domain;

public class Customer
{
    public Customer() { }
    public Customer(Guid id, string name, int zipCode, string city, Rating rating)
    {
        Id = id;
        Name = name ?? throw new ArgumentNullException(nameof(name));
        ZipCode = zipCode;
        City = city ?? throw new ArgumentNullException(nameof(city));
        Rating = rating;
    }

    public Guid Id { get; set; }

    public string Name { get; set; }

    public int ZipCode { get; set; }

    public string City { get; set; }

    public Rating Rating { get; set; }

    public decimal TotalRevenue { get; set; }
}
