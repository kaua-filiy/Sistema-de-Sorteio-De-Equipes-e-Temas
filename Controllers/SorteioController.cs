using Microsoft.AspNetCore.Mvc;
using Cadastro.Models;
using System;
using System.Collections.Generic;
using System.Linq;

public class SorteioController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {

        ViewBag.Pessoas = PessoaController.pessoas;
        ViewBag.Temas = TemaController.temas;
        
        return View();
    }

    [HttpPost]
    public IActionResult Resultado(int numeroEquipes)
    {
    
        var pessoas = PessoaController.pessoas;
        var temas = TemaController.temas;
        
        if (pessoas.Count == 0 || temas.Count == 0)
        {
            ViewBag.Erro = "É necessário cadastrar pelo menos uma pessoa e um tema para realizar o sorteio.";
            return View("Index");
        }
        
        if (numeroEquipes <= 0 || numeroEquipes > pessoas.Count)
        {
            ViewBag.Erro = "O número de equipes deve ser maior que zero e menor ou igual ao número de pessoas cadastradas.";
            return View("Index");
        }
        
    
        var random = new Random();
        var pessoasEmbaralhadas = pessoas.OrderBy(x => random.Next()).ToList();
        var temasEmbaralhados = temas.OrderBy(x => random.Next()).ToList();
        
       
        var equipes = new List<Equipe>();
        int pessoasPorEquipe = pessoas.Count / numeroEquipes;
        int equipesComPessoaExtra = pessoas.Count % numeroEquipes;
        
        int indicePessoa = 0;
        
        for (int i = 0; i < numeroEquipes; i++)
        {
            var equipe = new Equipe { Numero = i + 1 };
           
            int pessoasNestaEquipe = pessoasPorEquipe;
            if (i < equipesComPessoaExtra)
                pessoasNestaEquipe++;
                
            for (int j = 0; j < pessoasNestaEquipe && indicePessoa < pessoasEmbaralhadas.Count; j++)
            {
                equipe.Pessoas.Add(pessoasEmbaralhadas[indicePessoa]);
                indicePessoa++;
            }
            
    
            equipe.Tema = temasEmbaralhados[i % temasEmbaralhados.Count];
            
            equipes.Add(equipe);
        }
        
        return View(equipes);
    }
}
