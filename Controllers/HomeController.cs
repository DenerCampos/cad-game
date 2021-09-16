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
        //private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }

        public IActionResult Index()
        {
            return View(_gameRepository.Games);
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
