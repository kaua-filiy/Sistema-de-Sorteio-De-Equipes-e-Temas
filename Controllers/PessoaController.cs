using Microsoft.AspNetCore.Mvc;
using Cadastro.Models;

public class PessoaController : Controller
{
    public static List<Pessoa> pessoas = new();

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(Pessoa pessoa)
    {
        pessoas.Add(pessoa);
        return RedirectToAction("Confirmacao", pessoa);
    }

    public IActionResult Confirmacao(Pessoa pessoa)
    {
        return View(pessoa);
    }
}
