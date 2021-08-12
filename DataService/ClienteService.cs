using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using FluentValidation.Results;
using standBY_prototype.DataAccess;
using standBY_prototype.Models;

namespace standBY_prototype.DataService
{
  public class ClienteService : CommonService<Cliente>, IClienteService
  {
    public ClienteService(DataContext dbContext) : base(dbContext) { }

    public IEnumerable<Cliente> Search(string razao_social = null, string cnpj = null, bool? status = null)
    {
      if (string.IsNullOrWhiteSpace(razao_social) && string.IsNullOrWhiteSpace(cnpj) && status == null)
      {
        throw new ArgumentException("Deve ser passado ao menos um parâmetro para realizar uma busca.");
      }

      IEnumerable<Cliente> clientes = Get();

      if (status != null)
      {
        clientes = clientes.Where(c => c.status_cliente == status.GetValueOrDefault());
      }

      if (!string.IsNullOrWhiteSpace(cnpj))
      {
        cnpj = Regex.Replace(cnpj, @"\D", string.Empty);

        clientes = clientes.Where(c => c.cnpj.Contains(cnpj));
      }

      if (!string.IsNullOrWhiteSpace(razao_social))
      {
        razao_social = razao_social.ToLower();

        clientes = clientes.Where(c => c.razao_social.ToLower().Contains(razao_social));
      }

      return clientes;
    }

    public async Task<Cliente> SaveAsync(Cliente cliente)
    {
      if (string.IsNullOrWhiteSpace(cliente.data_fundacao.ToString()))
      {
        throw new ArgumentException("Data de fundação está fora do padrão.");
      }

      if (string.IsNullOrWhiteSpace(cliente.capital.ToString()))
      {
        throw new ArgumentException("Capital está fora do padrão.");
      }

      cliente.cnpj = Regex.Replace(cliente.cnpj, @"\D", string.Empty);
      if (cliente.Id != 0 || (_context.Clientes.All(c => c.razao_social != cliente.razao_social && c.cnpj != cliente.cnpj)))
      {
        cliente.quarentena = cliente.data_fundacao.AddYears(1) >= DateTime.Now
          ? cliente.quarentena = true
          : cliente.quarentena = false;

        cliente.classificacao = cliente.capital <= 10000
          ? 'C'
          : cliente.capital > 10000 && cliente.capital <= 1000000
            ? 'B'
            : 'A';

        ClienteValidator validator = new ClienteValidator();
        ValidationResult results = validator.Validate(cliente);

        if (results.IsValid)
        {
          return await Save(cliente);
        }
        else
        {
          throw new ArgumentException(results.ToString("\n"));
        }
      }

      throw new ArgumentException("Cliente com esta Razão Social ou CNPJ, já está cadastrado");
    }

    public async Task<bool> DeleteAsync(int id)
    {
      Cliente cliente = await GetById(id);

      if (cliente != null)
      {
        _context.Remove(cliente);
        await _context.SaveChangesAsync();
        return true;
      }

      return false;
    }
  }
}