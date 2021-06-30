using OnionArchitecture.DomainLayer.Models;
using OnionArchitecture.ServicesLayer.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnionArchitecture.ServicesLayer.CustomerService
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerViewModelInput>> GetAllCustomers();
        Task<Customer> GetCustomer(int id);

        Task<int> InsertCustomer(Customer customer);
        Task UpdateCustomer(Customer customer);
        Task DeleteCustomer(Customer customer);
    }
}
