using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSupport.BLL.Models.General
{
    public class ServiceResult<T>
    {
        public ServiceResult()
        {
            errors = new List<string>();
        }
        public List<string> errors;
        public Exception exception;

        public bool Succeeded
        {
            get
            {
                return !errors.Any();
            }
        }
    }
}
