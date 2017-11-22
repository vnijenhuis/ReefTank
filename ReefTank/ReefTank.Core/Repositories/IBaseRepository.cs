using ReefTank.Core.Domain;

namespace ReefTank.Core.Repositories
{
    public interface IBaseRepository<T> : IRepository<T> where T: class, IAggregateRoot
    {
        void SaveAndFlush(T model);
    }
}
