using CustomerSupport.DAL.Abstract;
using CustomerSupport.DAL.Models;

namespace CustomerSupport.DAL.Concrete
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        public VirtualDb<BaseEntity> _virtualDb;

        public Repository(VirtualDb<BaseEntity> virtualDb)
        {
            _virtualDb = virtualDb;
        }

        /// <summary>
        /// To insert object to virtural repository. VirtualDb is created as singleton.
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Insert(TEntity entity)
        {
            throw new Exception();
            _virtualDb.Enquires.Add(entity);
        }
        public virtual IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(long id)
        {
            throw new NotImplementedException();
        }
    }
}
