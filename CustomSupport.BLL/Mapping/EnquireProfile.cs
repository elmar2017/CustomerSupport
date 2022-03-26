using AutoMapper;
using CustomerSupport.BLL.Models.Dtos;
using CustomerSupport.DAL.Models;

namespace CustomerSupport.BLL.Mapping
{

    public class EnquireProfile : Profile
    {
        public EnquireProfile()
        {
            CreateMap<CreateEnquireDto, Enquire>().ReverseMap();
        }
    }
}
