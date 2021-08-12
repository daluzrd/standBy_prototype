using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using standBY_prototype.DataService;
using standBY_prototype.Models;

namespace standBY_prototype.Controllers
{
  public class ClienteController : Controller
  {
    private readonly IClienteService _clienteService;
    public ClienteController(IClienteService service) : base()
    {
      _clienteService = service;
    }

    [HttpGet]
    public IActionResult Index()
    {
      return View(_clienteService.Get());
    }

    [HttpGet]
    public async Task<IActionResult> CadastrarEditar(int id)
    {
      if (id == 0)
      {
        ViewData["Title"] = "Cliente | Cadastrar";

        return View();
      }
      else
      {
        ViewData["Title"] = "Cliente | Editar";

        return View(await _clienteService.GetById(id));
      }
    }

    [HttpPost]
    public async Task<IActionResult> CadastrarEditar(string razaoSocial, string cnpj, string dataFundacao, Decimal capital, bool status, int? id = null)
    {
      try
      {
        await _clienteService.SaveAsync(new Cliente(razaoSocial, cnpj, dataFundacao, capital, status, null, null, id));
        return RedirectToAction("Index");
      }
      catch (Exception e)
      {
        return View(new { error = e.Message });
      }
    }

    [HttpGet]
    public IActionResult GetCliente(string razaoSocial = null, string cnpj = null, bool? status = null)
    {
      try
      {
        if (string.IsNullOrWhiteSpace(razaoSocial) && string.IsNullOrWhiteSpace(cnpj) && status == null)
        {
          return Ok(_clienteService.Get());
        }

        return Ok(_clienteService.Search(razaoSocial, cnpj, status));
      }
      catch (Exception e)
      {
        return StatusCode(500, new { error = e.Message });
      }
    }

    [HttpGet]
    public async Task<IActionResult> GetClienteById(int id)
    {
      try
      {
        return Ok(await _clienteService.GetById(id));
      }
      catch (Exception e)
      {
        return StatusCode(500, new { error = e.Message });
      }
    }

    [HttpPost]
    public async Task<IActionResult> Delete(int id)
    {
      try
      {
        bool wasDeleted = await _clienteService.DeleteAsync(id);
        if (wasDeleted)
        {
          return Accepted();
        }
        return BadRequest(new { error = "Cliente não existe." });
      }
      catch (Exception e)
      {
        return StatusCode(500, e.Message);
      }
    }
  }
}