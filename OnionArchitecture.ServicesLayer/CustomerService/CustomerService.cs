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

        public async Task<IEnumerable<CustomerViewModel>> GetAllCustomers()
        {
            var result = await _repository.GetAll();
            return _mapper.Map<IEnumerable<CustomerViewModel>>(result);
        }
        public async Task<CustomerViewModel> GetCustomer(int id)
        {
            var result = await _repository.GetById(id);
            return _mapper.Map<CustomerViewModel>(result);
        }
        public void InsertCustomer(Customer customer)
        {
            _repository.Insert(customer);
        }
        public void UpdateCustomer(Customer customer)
        {
            _repository.Update(customer);
        }

        public void DeleteCustomer(int id)
        {
            var customer = GetCustomer(id);
            var customerMap = _mapper.Map<Customer>(customer);

            _repository.Remove(customerMap);

            _repository.SaveChanges();
        }
    }
}
