using System.Collections.Generic;
using NHibernate.Criterion;

namespace ReefTank.Core.Domain
{
    //Contains some base methods for the IRepository that should be readonly.
    public interface IReadOnlyRepository<T> where T : IAggregateRoot
    {
        T FindBy(object id);
        IEnumerable<T> FindBy(DetachedCriteria query);
        IEnumerable<T> FindAll();
        T FindOne();
        T FindFirst(DetachedCriteria query);
        int Count(DetachedCriteria query);

    }
}
