namespace ReefTank.Core.Domain
{
    //Base for working with entities in a repository.
    public interface IRepository<T> : IReadOnlyRepository<T> where T: IAggregateRoot
    {
        void Save(T entity);
        void Add(T entity);
        void Remove(T entity);
    }
}