using CustomerSupport.DAL.Concrete;
using CustomerSupport.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSupport.DAL.Abstract
{
    public interface IUnitOfWork
    {
        public Repository<Enquire> EnquireRepository { get; }
    }
}
