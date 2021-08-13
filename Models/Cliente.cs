using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FluentValidation;
using standBY_prototype.Common;

namespace standBY_prototype.Models
{
  public class Cliente : BaseModel
  {

    [Required]
    public string razao_social { get; set; }
    public string cnpj { get; set; }
    public DateTime data_fundacao { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public Decimal capital { get; set; }
    public bool quarentena { get; set; }
    public bool status_cliente { get; set; }
    public char classificacao { get; set; }

    public Cliente() { }

    public Cliente(string new_razao_social = null, string new_cnpj = null, string new_data_fundacao = null, Decimal? new_capital = null, bool? new_status_cliente = null, bool? new_quarentena = null, char? new_classificacao = null, int? new_id = null)
    {
      razao_social = new_razao_social;
      cnpj = new_cnpj;
      data_fundacao = CommonMethods.TryConvertToDateTime(new_data_fundacao);
      capital = CommonMethods.GetValueOrDefault(new_capital);
      quarentena = CommonMethods.GetValueOrDefault(new_quarentena);
      status_cliente = CommonMethods.GetValueOrDefault(new_status_cliente);
      classificacao = CommonMethods.GetValueOrDefault(classificacao);
      Id = CommonMethods.GetValueOrDefault(new_id);
    }
  }

  public class ClienteValidator : AbstractValidator<Cliente>
  {
    public ClienteValidator()
    {
      RuleFor(c => c.razao_social).NotNull().WithMessage("Razão social é obrigatória.").NotEmpty().WithMessage("Razão social é obrigatória.");
      RuleFor(c => c.cnpj).NotNull().WithMessage("CNPJ é obrigatório.").NotEmpty().WithMessage("CNPJ é obrigatório.");
      RuleFor(c => c.cnpj).Length(14).WithMessage("CNPJ incompleto.");
      RuleFor(c => c.cnpj).Must(StringHaveOnlyDigits).WithMessage("CNPJ deve conter apenas dígitos.");
      RuleFor(c => c.data_fundacao).NotNull().WithMessage("Data de fundação é obrigatória").NotEmpty().WithMessage("Data de fundação é obrigatória");
      RuleFor(c => c.data_fundacao).LessThan(DateTime.Now).WithMessage("Data de fundação inválida");
      RuleFor(c => c.capital).NotNull().WithMessage("Capital é obrigatório");
      RuleFor(c => c.capital).GreaterThanOrEqualTo(0).WithMessage("Capital deve ser positivo");
      RuleFor(c => c.quarentena).NotNull().WithMessage("Quarentena é obrigatória.");
      RuleFor(c => c).Must(c => QuarentenaIsValid(c.quarentena, c.data_fundacao)).WithMessage("Quarentena incorreta");
      RuleFor(c => c.status_cliente).NotNull().WithMessage("Status é obrigatório.");
      RuleFor(c => c.classificacao).NotNull().WithMessage("Classificação é obrigatória.");
      RuleFor(c => c).Must(c => ClassificacaoIsValid(c.classificacao, c.capital)).WithMessage("Classificação incorreta.");
    }

    private bool StringHaveOnlyDigits(string value)
    {
      foreach (char c in value)
      {
        if (c < '0' || c > '9')
        {
          return false;
        }
      }
      return true;
    }

    private bool QuarentenaIsValid(bool quarentena, DateTime data_fundacao)
    {
      DateTime new_data_fundacao = data_fundacao.AddYears(1);
      if (quarentena && new_data_fundacao >= DateTime.Now)
      {
        return true;
      }
      else if (!quarentena && new_data_fundacao < DateTime.Now)
      {
        return true;
      }
      return false;
    }

    private bool ClassificacaoIsValid(char classificacao, decimal capital)
    {
      return capital <= 10000
          ? classificacao == 'C'
          : capital > 10000 && capital <= 1000000
            ? classificacao == 'B'
            : classificacao == 'A';
    }
  }

}