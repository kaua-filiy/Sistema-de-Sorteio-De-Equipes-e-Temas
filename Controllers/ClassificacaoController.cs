using Microsoft.AspNetCore.Mvc;
using Cadastro.Models;

public class ClassificacaoController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Resultado(List<Pessoa> pessoas)
    {
        var maiores = pessoas.Where(p => p.Idade >= 18).ToList();
        var menores = pessoas.Where(p => p.Idade < 18).ToList();

        ViewBag.Maiores = maiores;
        ViewBag.Menores = menores;

        return View();
    }
}
