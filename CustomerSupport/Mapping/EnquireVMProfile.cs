using AutoMapper;
using CustomerSupport.BLL.Models.Dtos;
using CustomerSupport.Models.ViewModels;

namespace CustomerSupport.Mapping
{
  
    public class EnquireVMProfile : Profile
    {
        public EnquireVMProfile()
        {
            CreateMap<CreateEnquireDto, CreateEnquireVM>().ReverseMap();
        }
    }
}
