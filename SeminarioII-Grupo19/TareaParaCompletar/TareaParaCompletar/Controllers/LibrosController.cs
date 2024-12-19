using Microsoft.AspNetCore.Mvc;
using TareaParaCompletar.Models;

namespace TareaParaCompletar.Controllers
{
    public class LibrosController : Controller
    {
        // Lista simulada de libros
        public static List<Libro> listaLibros = new List<Libro>
        {
            new Libro { Id = 1, Titulo = "El Principito", Autor = "Antoine de Saint-Exupéry" },
            new Libro { Id = 2, Titulo = "1984", Autor = "George Orwell" }
        };

        // Acción Index para mostrar la lista de libros
        public IActionResult Index()
        {
            return View(listaLibros);
        }

        // Acción GET para crear un nuevo libro
        public IActionResult Crear()
        {
            return View();
        }

        // Acción POST para guardar el nuevo libro
        [HttpPost]
        public IActionResult Crear(Libro libro)
        {
            libro.Id = listaLibros.Max(l => l.Id) + 1; // Generar ID único
            listaLibros.Add(libro);
            return RedirectToAction("Index");
        }
    }
}
