using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using standBY_prototype.Models;

namespace standBY_prototype.DataService
{
  public interface IClienteService : ICommonService<Cliente>
  {
    IEnumerable<Cliente> Search(string razao_social = null, string cnpj = null, bool? status = null);
    Task<Cliente> SaveAsync(Cliente cliente);
    Task<bool> DeleteAsync(int id);
  }
}