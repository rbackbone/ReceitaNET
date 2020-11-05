using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using mvc001.Models;
using System.Diagnostics;
using mvc001.Repositorio;

namespace mvc001.Controllers
{
    public class ReceitaController : Controller
    {
        private readonly ILogger<ReceitaController> _logger;
        private readonly IRepositorioInsumo repositorioInsumo;
        private readonly IRepositorioReceita repositorioReceita;
        private readonly IRepositorioItemReceita repositorioItemReceita;

        public ReceitaController(ILogger<ReceitaController> logger,
                                 IRepositorioInsumo _repositorioInsumo,
                                 IRepositorioReceita _repositorioReceita,
                                 IRepositorioItemReceita _repositorioItemReceita)
        {
            _logger = logger;
            this.repositorioInsumo = _repositorioInsumo;
            this.repositorioReceita = _repositorioReceita;
            this.repositorioItemReceita = _repositorioItemReceita;
        }

        public IActionResult Carrossel()
        {
            return View(repositorioReceita.GetReceitas());

        }
        public IActionResult NovaReceita(int receitaId)
        {

            Receita receita = repositorioReceita.GetReceita(receitaId);

            return View(receita);

        }

        public IActionResult Itens(string codigo)
        {
            if (!string.IsNullOrEmpty(codigo))
            {
                repositorioReceita.AddInsumo(codigo);
            }

            IList<Insumo> insumos = repositorioInsumo.GetInsumos();
            return View(insumos);

        }

        [HttpPost]
        public AlteraQuantidadeResposta AlteraQuantidade([FromBody]ItemReceita itemReceita)
        {
            return repositorioItemReceita.AlteraQuantidade(itemReceita);

        }

        public IActionResult Cadastro()
        {
            return View();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
