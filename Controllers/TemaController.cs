using Microsoft.AspNetCore.Mvc;
using Cadastro.Models;

public class TemaController : Controller
{
    public static List<Tema> temas = new();

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(Tema tema)
    {
        temas.Add(tema);
        return RedirectToAction("Confirmacao", tema);
    }

    public IActionResult Confirmacao(Tema tema)
    {
        return View(tema);
    }
}
