using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSupport.DAL.Models
{
    public class VirtualDb<T> where T: BaseEntity
    {
        public VirtualDb()
        {
            Enquires = new List<BaseEntity>();
        }
        public List<BaseEntity> Enquires { get; set; }
    }
}
