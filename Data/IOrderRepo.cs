using OrdersWebApp.Models;

namespace OrdersWebApp.Data;

public interface IOrderRepo
{
    Task<bool> SaveChangesAsync();

    Task<Order?> GetOrderByIdAsync(Guid id);

    Task<IEnumerable<Order>> GetAllOrdersAsync();

    Task CreateOrderAsync(Order order);

    void DeleteOrder(Order order);
}
