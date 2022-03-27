using CustomerSupport.BLL.Models.Dtos;
using CustomerSupport.BLL.Models.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSupport.BLL.Abstract
{
    public interface IEnquireService
    {
        void CreateInquire(CreateEnquireDto createEnquiryDto);
    }
}
