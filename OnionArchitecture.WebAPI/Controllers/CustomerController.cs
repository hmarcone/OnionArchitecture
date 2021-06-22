using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.DomainLayer.Models;
using OnionArchitecture.ServicesLayer.CustomerService;

namespace OnionArchitecture.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        #region Property  
        private readonly ICustomerService _customerService;
        #endregion

        #region Constructor  
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        #endregion

        [HttpGet(nameof(GetCustomer))]
        public IActionResult GetCustomer(int id)
        {
            var result = _customerService.GetCustomer(id);

            if(result is not null)
            {
                return Ok(result);
            }

            return BadRequest("Nenhum registro encontrado!");
        }

        [HttpGet(nameof(GetAllCustomer))]
        public IActionResult GetAllCustomer()
        {
            var result = _customerService.GetAllCustomers();

            if (result is not null)
            {
                return Ok(result);
            }

            return BadRequest("Nenhum registro encontrado!");
        }

        [HttpPost(nameof(InsertCustomer))]
        public IActionResult InsertCustomer(Customer customer)
        {
            //if (ModelState.IsValid)
            //{
                _customerService.InsertCustomer(customer);
                return Ok("Dados inseridos com sucesso!");
            //}
            //else
            //{
            //    return BadRequest();
            //}
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
