using AutoMapper;
using CustomerSupport.BLL.Abstract;
using CustomerSupport.BLL.Models.Dtos;
using CustomerSupport.BLL.Models.General;
using CustomerSupport.DAL.Abstract;
using CustomerSupport.DAL.Models;


namespace CustomerSupport.BLL.Concrete
{
    public class EnquireService : IEnquireService
    {
        private readonly IUnitOfWork _unitOfWork;
        public readonly IMapper _mapper;
        public EnquireService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public ServiceResult<bool> CreateInquire(CreateEnquireDto createEnquiryDto)
        {
            var serviceResult = new ServiceResult<bool>();
            try
            {
                _unitOfWork.EnquireRepository.Insert(_mapper.Map<Enquire>(createEnquiryDto));
            }
            catch (Exception ex)
            {
                serviceResult.exception = ex;
                serviceResult.errors.Add("Error happened while adding enquire");
            }
            return serviceResult;

        }
    }
}
