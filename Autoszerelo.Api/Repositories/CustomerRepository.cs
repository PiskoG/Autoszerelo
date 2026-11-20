using Autoszerelo.Api.Data;
using Autoszerelo.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Autoszerelo.Api.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private readonly AppDbContext _dbContext;

    public CustomerRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<List<Customer>> GetCustomersAsync()
    {
        return _dbContext.Customers.AsNoTracking()
            .OrderBy(customer => customer.Name)
            .ToListAsync();
    }

    public Task<Customer?> GetCustomerAsync(int id)
    {
        return _dbContext.Customers
            .FirstOrDefaultAsync(customer => customer.Id == id);
    }

    public void AddCustomer(Customer customer)
    {
        _dbContext.Customers.Add(customer);
    }

    public void DeleteCustomer(Customer customer)
    {
        _dbContext.Customers.Remove(customer);
    }

    public Task SaveChangesAsync()
    {
        return _dbContext.SaveChangesAsync();
    }
}