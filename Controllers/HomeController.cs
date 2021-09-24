using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using cad_games.Models;

namespace cad_games.Controllers
{
    public class HomeController : Controller
    {
        private IGameRepository _gameRepository;

        public HomeController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public IActionResult Index()
        {
            var teste = _gameRepository.findAll;
            return View(_gameRepository.findAll);
        }

        public IActionResult Create()
        {
            //_gameRepository.create(new Game("teste", true, "2021-06-07"));
            return View(_gameRepository.findAll);
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
}
