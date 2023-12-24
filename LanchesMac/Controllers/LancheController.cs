using LanchesMac.Repositories.Interfaces;
using LanchesMac.ViewsModels;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Emit;

namespace LanchesMac.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            //var lanches = _lancheRepository.Lanches;
            //return View(lanches);
            var lancheListViewModel = new LancheListViewModel();
            lancheListViewModel.Lanches = _lancheRepository.Lanches;
            lancheListViewModel.CategiruaAtual = "categoria atual";

            return View(lancheListViewModel);
        }
    }
}
