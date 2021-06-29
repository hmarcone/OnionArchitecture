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

        void InsertCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int id);
    }
}
