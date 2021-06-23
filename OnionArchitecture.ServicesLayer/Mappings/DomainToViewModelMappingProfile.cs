using AutoMapper;
using OnionArchitecture.DomainLayer.Models;
using OnionArchitecture.ServicesLayer.ViewModels;

namespace OnionArchitecture.ServicesLayer.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Customer, CustomerViewModel>();
        }
    }
}
