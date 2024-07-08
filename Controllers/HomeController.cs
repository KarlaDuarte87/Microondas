using Microondas_Digital.Models;
using Microondas_Digital.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Microondas_Digital.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProgramaRepositorio _programaRepositorio;
        public HomeController(IProgramaRepositorio programaRepositorio)
        {
            _programaRepositorio = programaRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult VerProgramas()
        {
            List<Programas> programas = _programaRepositorio.BuscarTodos();
            return View(programas);
        }


        public IActionResult CadastrarPrograma()
        {
            return View();
        }

        public IActionResult EditarPrograma(int id)
        {
            Programas programa = _programaRepositorio.ListarPorId(id);
            return View(programa);
        }

        [HttpPost]
        public IActionResult CadastrarPrograma(Programas programas)
        {
            _programaRepositorio.Adicionar(programas);
            return RedirectToAction("Index");
        }



        [HttpPost]
        public IActionResult AlterarPrograma(Programas programas)
        {
            _programaRepositorio.Atualizar(programas);
            return RedirectToAction("Index");
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
