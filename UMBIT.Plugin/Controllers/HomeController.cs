using Microsoft.AspNetCore.Mvc;
using UMBIT.Plugin.Dominio.Entidades;
using UMBIT.Plugin.Dominio.Interfaces;

namespace UMBIT.Plugin.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServicoDePessoa servicoDePessoa;
        public HomeController(IServicoDePessoa servicoDePessoa)
        {
            this.servicoDePessoa = servicoDePessoa;
        }

        public IActionResult Index()
        {
            this.servicoDePessoa.Adicione(new Pessoa());
            return View();
        }


    }
}