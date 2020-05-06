using AutoMapper;
using Ecommerce.CtrlX.Application.ViewModels;
using Ecommerce.CtrlX.Domain.Entities;

namespace Ecommerce.CtrlX.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Departaments, DepartamentsViewModel>();
        }
    }
}
