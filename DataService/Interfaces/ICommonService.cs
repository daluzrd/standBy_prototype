using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace standBY_prototype.DataService
{
  public interface ICommonService<T> where T : class
  {
    IEnumerable<T> Get();

    Task<T> GetById(int id);

    IEnumerable<T> GetByFilter(Expression<Func<T, bool>> filter);
  }
}