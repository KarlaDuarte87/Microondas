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


        public IActionResult ApagarConfirmacao(int id)
        {
            Programas programa = _programaRepositorio.ListarPorId(id);

            return View(programa);
        }


        public IActionResult Apagar(int id)
        {
            _programaRepositorio.Apagar(id);
            return RedirectToAction("VerProgramas");
        }

        [HttpPost]
        public IActionResult CadastrarPrograma(Programas programas)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    _programaRepositorio.Adicionar(programas);
                    TempData["MensagemSucesso"] = "Programa cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos Editar o Programa, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }


            return View(programas);


        }
       
        [HttpPost]
        public IActionResult AlterarPrograma(Programas programas)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _programaRepositorio.Atualizar(programas);
                    TempData["MensagemSucesso"] = "Programa editado com sucesso";
                    return RedirectToAction("Index");
                }

                return View("EditarPrograma", programas);

            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos Editar o Programa, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }

        }




     
         
            [HttpPost]
            public IActionResult IniciarAquecimento(int tempoEmSegundos, int potencia = 10)
            {
                try
                {
                    var microondas = new Microondas();
                    microondas.IniciarAquecimento(tempoEmSegundos, potencia);
                    ViewBag.Message = $"Aquecimento iniciado por {tempoEmSegundos} segundos na potência {potencia}.";
                    return View("AquecimentoIniciado");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    ViewBag.ErrorMessage = ex.Message;
                    return View("Error", new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
                }
            }
        









        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
