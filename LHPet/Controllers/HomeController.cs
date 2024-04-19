using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    
    public IActionResult Index()
    {
        Cliente cliente1  = new Cliente(01,"Guilherme T","00000000000", "guitprates@gmail.com","lili");
        Cliente cliente2  = new Cliente(02,"Ana Silva","11111111111", "ana.silva@example.com","bob");
        Cliente cliente3  = new Cliente(03,"Carlos Oliveira","22222222222", "carlos.oliveira@example.com","pity");
        Cliente cliente4  = new Cliente(04,"Maria Souza","33333333333", "maria.souza@example.com","tob");
        Cliente cliente5  = new Cliente(05,"Pedro Santos","44444444444", "pedro.santos@example.com","lala");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        Fornecedor fornecedor1 = new Fornecedor(06,"Pets Inc","13432342000170","petsinc@pets.com.br");
        Fornecedor fornecedor2 = new Fornecedor(06,"Foods Pet","13432342000170","petsinc@pets.com.br");
        Fornecedor fornecedor3 = new Fornecedor(06,"Kids Pets","13432342000170","petsinc@pets.com.br");
        Fornecedor fornecedor4 = new Fornecedor(06,"Brinks Pets","13432342000170","petsinc@pets.com.br");
        Fornecedor fornecedor5 = new Fornecedor(06,"Pets LTDA","13432342000170","petsinc@pets.com.br");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
