using Autoszerelo.Api.Models;

namespace Autoszerelo.Api.Repositories;

public interface ICustomerRepository
{
    Task<List<Customer>> GetCustomersAsync();

    Task<Customer?> GetCustomerAsync(int id);

    void AddCustomer(Customer customer);

    void DeleteCustomer(Customer customer);

    Task SaveChangesAsync();
}