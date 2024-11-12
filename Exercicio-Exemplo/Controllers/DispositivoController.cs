using Exercicio_Exemplo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Exercicio_Exemplo.Controllers
{
    public class DispositivoController : Controller
    {
        public IActionResult Index()
        {
            List<DispositivoEletronico> dispositivos = new List<DispositivoEletronico>
            {
                new Computador { Marca = "Dell", Modelo = "Inspirion", AnoDeFabricacao = 2021, EhLaptop = true, MemoriaRAM = 16, SistemaOperacional= "Windows 11"},
                new Computador { Marca = "Samsung", Modelo = "Galaxy Book", AnoDeFabricacao = 2021, EhLaptop = false, MemoriaRAM = 16, SistemaOperacional= "Windows 11"},
                new Smartphone { Marca = "Apple", Modelo = "Iphone 11", AnoDeFabricacao = 2012, Tem5G = true}
            };
            return View(dispositivos);
    }
    }
}
