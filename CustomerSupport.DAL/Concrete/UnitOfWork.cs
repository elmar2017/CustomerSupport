using CustomerSupport.DAL.Abstract;
using CustomerSupport.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSupport.DAL.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private Repository<Enquire> enquireRepository;
        private VirtualDb<BaseEntity> _virtualDb;

        public UnitOfWork(VirtualDb<BaseEntity> virtualDb)
        {
            _virtualDb = virtualDb;
        }


        public Repository<Enquire> EnquireRepository
        {
            get
            {
                if (this.enquireRepository == null)
                {
                    this.enquireRepository = new Repository<Enquire>(_virtualDb);
                }
                return enquireRepository;
            }
        }


        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
