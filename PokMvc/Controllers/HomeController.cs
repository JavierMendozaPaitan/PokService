using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataProvDom.Services;
using DataProvDomBase.Interfaces;
using DataProvDomBase.Reports;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PokMvc.Models;

namespace PokMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(IPokSrv pok, ILogger<HomeController> logger)
        {
            _logger = logger;
            this.pok = (PokSrv)pok;
        }

        private readonly PokSrv pok;

        public IActionResult Test()
        {
            try
            {                

                return View();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IActionResult> Index(string text, string PokSelect)
        {
            try
            {
                var pklst = await pok.FilterOptPoks(text, PokSelect);

                return View(pklst);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IActionResult> Pokedex(string id)
        {
            try
            {
                var pkd = await pok.ShowPok(id);

                return View(pkd);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
