using AutoMapper;
using Ecommerce.CtrlX.Application.ViewModels;
using Ecommerce.CtrlX.Domain.Entities;

namespace Ecommerce.CtrlX.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<DepartamentsViewModel, Departaments>();
        }
    }
}
