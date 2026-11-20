using Autoszerelo.Api.Models;

namespace Autoszerelo.Api.Services;

public interface ICustomerService
{
    Task<List<Customer>> GetCustomersAsync();

    Task<Customer> GetCustomerAsync(int id);

    Task<int> AddCustomerAsync(Customer customer);

    Task UpdateCustomerAsync(int id, Customer customer);

    Task DeleteCustomerAsync(int id);
}