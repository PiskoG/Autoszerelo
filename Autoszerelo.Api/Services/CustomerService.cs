using Autoszerelo.Api.Exceptions;
using Autoszerelo.Api.Models;
using Autoszerelo.Api.Repositories;

namespace Autoszerelo.Api.Services;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository
                              ?? throw new ArgumentNullException(nameof(customerRepository));
    }

    public Task<List<Customer>> GetCustomersAsync()
    {
        return _customerRepository.GetCustomersAsync();
    }

    public Task<Customer> GetCustomerAsync(int id)
    {
        return GetRequiredCustomerAsync(id);
    }

    public async Task<int> AddCustomerAsync(Customer customer)
    {
        ArgumentNullException.ThrowIfNull(customer);

        _customerRepository.AddCustomer(customer);
        await _customerRepository.SaveChangesAsync();
        return customer.Id;
    }

    public async Task UpdateCustomerAsync(int id, Customer customer)
    {
        ArgumentNullException.ThrowIfNull(customer);

        var customerToUpdate = await GetRequiredCustomerAsync(id);
        customerToUpdate.Name = customer.Name;
        customerToUpdate.Address = customer.Address;
        customerToUpdate.Email = customer.Email;
        await _customerRepository.SaveChangesAsync();
    }

    public async Task DeleteCustomerAsync(int id)
    {
        var customer = await GetRequiredCustomerAsync(id);
        _customerRepository.DeleteCustomer(customer);
        await _customerRepository.SaveChangesAsync();
    }

    private async Task<Customer> GetRequiredCustomerAsync(int id)
    {
        var customer = await _customerRepository.GetCustomerAsync(id);
        if (customer is null)
        {
            throw new EntityNotFoundException($"Customer with Id '{id}' does not exist");
        }

        return customer;
    }
}