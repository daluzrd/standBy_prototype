using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using standBY_prototype.DataAccess;
using standBY_prototype.Models;

namespace standBY_prototype.DataService
{
  public class CommonService<T> : ICommonService<T> where T : BaseModel
  {
    protected readonly DataContext _context;
    public CommonService(DataContext dbContext)
    {
      _context = dbContext;
    }

    public IEnumerable<T> Get()
    {
      return _context.Set<T>().AsEnumerable();
    }

    public async Task<T> GetById(int id)
    {
      return await _context.Set<T>().FindAsync(id);
    }

    public IEnumerable<T> GetByFilter(Expression<Func<T, bool>> filter)
    {
      return _context.Set<T>().Where(filter).AsEnumerable();
    }

    public async Task<T> Save(T entity)
    {
      if (entity.Id > 0)
      {
        _context.Update(entity);
      }
      else
      {
        await _context.AddAsync(entity);
      }
      await _context.SaveChangesAsync();

      return entity;
    }
  }
}