using RestaurantManager.Business.Definitions.Base;
using RestaurantManager.Database.Repositories.Definitions;
using RestaurantManager.Database.Repositories.Implementations;
using RestaurantManager.Database.UOW;
using RestaurantManager.Model.Entities.Base;

namespace RestaurantManager.Business.Implementations.Base
{
    public class GenericBusiness<T> : IGenericBusiness<T> where T : BaseEntity
    {
        protected readonly IGenericRepository<T> Repository;
        protected readonly IUnitOfWork UnitOfWork;

        public GenericBusiness(IUnitOfWork unitOfWork)
        {
            Repository = new GenericRepository<T>(unitOfWork.Context);
            UnitOfWork = unitOfWork;
        }

        public virtual async Task Delete(int id)
        {
            await Repository.Delete(id);
            await Repository.Save();
        }

        public virtual async Task<List<T>> GetAll()
        {
            return await Repository.GetAll();
        }

        public virtual async Task<T> GetById(int id)
        {
            return await Repository.Get(expression: q => q.ID == id);
        }

        public virtual async Task Save(T obj)
        {

            if (obj.ID == 0)
            {
                await Repository.Insert(obj);
            }
            else
            {
                Repository.Update(obj);
            }

            await Repository.Save();

        }
    }
}
