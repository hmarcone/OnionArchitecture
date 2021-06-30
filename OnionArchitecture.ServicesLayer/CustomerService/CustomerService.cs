using AutoMapper;
using OnionArchitecture.DomainLayer.Models;
using OnionArchitecture.RepositoryLayer.RespositoryPattern;
using OnionArchitecture.ServicesLayer.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnionArchitecture.ServicesLayer.CustomerService
{
    public class CustomerService : ICustomerService
    {
        #region Property  
        private IRepository<Customer> _repository;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor  
        public CustomerService(IMapper mapper, IRepository<Customer> repository)
        {
            _repository = repository;
            _mapper = mapper;
        }
        #endregion

        public async Task<IEnumerable<CustomerViewModelInput>> GetAllCustomers()
        {
            var result = await _repository.FindAllAsync();
            return _mapper.Map<IEnumerable<CustomerViewModelInput>>(result);
        }

        public async Task<Customer> GetCustomer(int id)
        {
            return await _repository.FindAsync(id);
            //var result = await _repository.FindAsync(id);
            //return result;

            //return _mapper.Map<CustomerViewModelInput>(result);
        }
        public async Task<int> InsertCustomer(Customer customer)
        {
            return await _repository.Insert(customer);
        }
        public async Task UpdateCustomer(Customer customer)
        {
            await _repository.Update(customer);
        }

        public async Task DeleteCustomer(Customer customer)
        {
            //var customer = GetCustomer(id);
            //var customerMap = _mapper.Map<Customer>(customer);

            _repository.Remove(customer);

            await _repository.SaveChanges();
        }
    }
}
