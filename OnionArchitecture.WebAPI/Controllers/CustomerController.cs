using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.DomainLayer.Models;
using OnionArchitecture.ServicesLayer.CustomerService;
using OnionArchitecture.ServicesLayer.Filters;
using OnionArchitecture.ServicesLayer.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace OnionArchitecture.WebAPI.Controllers
{
    [Route("api/v1/customer")]
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

        [HttpGet(nameof(GetCustomer) + "/{id}")]
        public async Task<IActionResult> GetCustomer(int id)
        {
            var result = await _customerService.GetCustomer(id);

            if(result is not null)
            {
                return Ok(result);
            }

            return NotFound("Nenhum registro encontrado para este identificador!");
            //return NotFound(
            //        new
            //        {
            //            Mensagem = "Código de cliente inválido ou item inexistente.",
            //            Erro = true
            //        });
            //return await Task.FromResult(new ActionResult(404, "", result));
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
        [ValidacaoModelStateCustomizado]
        public async Task<IActionResult> InsertCustomer(CustomerViewModelInput customerViewModel)
        {
            var customer = _mapper.Map<Customer>(customerViewModel);

            await _customerService.InsertCustomer(customer);

            return Created("Dados inseridos com sucesso!", customerViewModel);            
        }

        [HttpPut(nameof(UpdateCustomer) + "/{id}")]
        [ValidacaoModelStateCustomizado]
        public async Task<IActionResult> UpdateCustomer(int id, CustomerViewModelInput customerViewModel)
        {
            var customerDb = await GetCustomer(id);

            if (customerDb is null)
            {
                return NotFound("Código do cliente inválido ou inexistente!");
            }

            customerViewModel.Id = id;
            var customer = _mapper.Map<Customer>(customerViewModel);

            await _customerService.UpdateCustomer(customer);

            //return new ObjectResult(customerViewModel);

            //return Ok("Dados alterados com sucess!");
            return Ok(customerViewModel);
        }

        [HttpDelete(nameof(DeleteCustomer) + "/{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var result = await _customerService.GetCustomer(id);

            if (result is null)
            {
                return NotFound("Código do cliente inválido ou inexistente!");
            }

            //await _customerService.DeleteCustomer(id);
            await _customerService.DeleteCustomer(result);

            return Ok("Registro deletado com sucesso!");

        }
    }
}
