namespace Autoszerelo.Api.Models;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; }= string.Empty;
    public string Email { get; set; }= string.Empty;
    public List<Job> Jobs { get; set; } = new();
}