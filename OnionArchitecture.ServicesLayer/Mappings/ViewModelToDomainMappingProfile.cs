using AutoMapper;
using OnionArchitecture.DomainLayer.Models;
using OnionArchitecture.ServicesLayer.ViewModels;

namespace OnionArchitecture.ServicesLayer.Mappings
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CustomerViewModelInput, Customer>();
        }
    }
}
