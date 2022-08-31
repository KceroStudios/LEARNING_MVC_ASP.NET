using Microsoft.AspNetCore.Mvc;
using portafolio.Models;
using System.Diagnostics;

namespace portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModels() { Proyectos = proyectos };
            return View(modelo);
        }

        private List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto
                {
                    Titulo = "proyecto1",
                    Descripcion = "Lorem Ipsum Dolor Sit Amet",
                    Link = "#",
                    Img = "/img/ai.png"
                },

                new Proyecto
                {
                    Titulo = "proyecto2",
                    Descripcion = "Lorem Ipsum Dolor Sit Amet",
                    Link = "#",
                    Img = "/img/ai.png"
                },

                new Proyecto
                {
                    Titulo = "proyecto3",
                    Descripcion = "Lorem Ipsum Dolor Sit Amet",
                    Link = "#",
                    Img = "/img/ai.png"
                },

                new Proyecto
                {
                    Titulo = "proyecto4",
                    Descripcion = "Lorem Ipsum Dolor Sit Amet",
                    Link = "#",
                    Img = "/img/ai.png"
                },
            };
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