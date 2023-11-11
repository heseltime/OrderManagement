using OrderManagement.Domain;

namespace OrderManagement.Logic;

public interface IOrderManagementLogic
{
    Task<IEnumerable<Customer>> GetCustomers();
    Task<IEnumerable<Customer>> GetCustomersByRating(Rating rating);
    Task<bool> CustomerExists(Guid customerId);
    Task<Customer?> GetCustomer(Guid customerId);
    Task AddCustomer(Customer customer);
    Task<bool> DeleteCustomer(Guid customerId);
    Task UpdateCustomer(Customer customer);

    Task<IEnumerable<Order>> GetOrdersOfCustomer(Guid customerId);
    Task<bool> OrderExists(Guid order);
    Task<Order> GetOrder(Guid orderId);
    Task AddOrderForCustomer(Guid customerId, Order order);
    Task UpdateOrder(Order order);
    Task<bool> DeleteOrder(Guid orderId);

    Task<decimal> UpdateTotalRevenue(Guid customerId);
    Task UpdateTotalRevenues();

}
