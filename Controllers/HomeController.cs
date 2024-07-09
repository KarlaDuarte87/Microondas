using Microondas_Digital.Models;
using Microondas_Digital.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

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
            var programas = _programaRepositorio.BuscarTodos().Select(p => p.Nome).ToList();
            return View(programas ?? new List<string>());
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
            try
            {
                _programaRepositorio.Apagar(id);
                TempData["MensagemSucesso"] = "Programa apagado com sucesso";
                return RedirectToAction("VerProgramas");
            }
            catch (System.Exception erro)
            {
               TempData["MensagemErro"] = $"Ops, não conseguimos realizar essa ação, tente novamente, detalhe do erro: {erro.Message}";
               return RedirectToAction("VerProgramas");
            }
           
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
                    //return RedirectToAction("Index");
                    

                }
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos Editar o Programa, tente novamente, detalhe do erro: {erro.Message}";
                //return RedirectToAction("VerProgramas");
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
                }

                return View("EditarPrograma", programas);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos Editar o Programa, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("VerProgramas");
            }
        }

        [HttpPost]
        public async Task<IActionResult> IniciarAquecimento(int? tempoEmSegundos, int? potencia)
        {
            int tempo = tempoEmSegundos ?? 30;
            int power = potencia ?? 10;

            try
            {
                var microondas = new Microondas();
                microondas.IniciarAquecimento(tempo, power);

                StringBuilder processo = new StringBuilder();
                for (int i = 0; i < tempo; i++)
                {
                    processo.Append(new string('.', power));
                    processo.Append(' ');

                    await Task.Delay(1000);

                    return Json(new { processo = processo.ToString() });
                }
                processo.Append("Aquecimento concluído.");

                ViewBag.Message = $"Aquecimento iniciado por {tempo} segundos na potência {power}.";
                ViewBag.Processo = processo.ToString();

                return Json(new { processo = processo.ToString(), message = ViewBag.Message });
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
