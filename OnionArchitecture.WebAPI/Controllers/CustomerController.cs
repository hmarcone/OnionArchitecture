using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.DomainLayer.Models;
using OnionArchitecture.ServicesLayer.CustomerService;
using OnionArchitecture.ServicesLayer.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace OnionArchitecture.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        #region Property  
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor  
        public CustomerController(IMapper mapper, ICustomerService customerService)
        {
            _customerService = customerService;
            _mapper = mapper;
        }
        #endregion

        [HttpGet(nameof(GetCustomer))]
        public async Task<IActionResult> GetCustomer(int id)
        {
            var result = await _customerService.GetCustomer(id);

            if(result is not null)
            {
                return Ok(result);
            }

            return BadRequest("Nenhum registro encontrado!");
        }

        [HttpGet(nameof(GetAllCustomer))]
        public async Task<IActionResult> GetAllCustomer()
        {
            var result = await _customerService.GetAllCustomers();

            if (result is not null)
            {
                return Ok(result);
            }

            return BadRequest("Nenhum registro encontrado!");
        }

        [HttpPost(nameof(InsertCustomer))]
        public IActionResult InsertCustomer(CustomerViewModel customerViewModel)
        {
            if (ModelState.IsValid)
            {
                var customer = _mapper.Map<Customer>(customerViewModel);

                _customerService.InsertCustomer(customer);
                return Ok("Dados inseridos com sucesso!");
            }
            else
            {
                //ToDo: verificar depois a necessidade desta validação do modelState
                var message = string.Join(" | ", ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage));

                return BadRequest(message);
            }
        }

        [HttpPut(nameof(UpdateCustomer))]
        public IActionResult UpdateCustomer(Customer customer)
        {
            _customerService.UpdateCustomer(customer);
            return Ok("Dados alterados com sucess!");
        }

        [HttpDelete(nameof(DeleteCustomer))]
        public IActionResult DeleteCustomer(int Id)
        {
            _customerService.DeleteCustomer(Id);
            return Ok("Registro deletado com sucesso!");

        }
    }
}
