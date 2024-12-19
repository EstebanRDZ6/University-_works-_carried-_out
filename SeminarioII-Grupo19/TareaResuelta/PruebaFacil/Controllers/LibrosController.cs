using Microsoft.AspNetCore.Mvc;
using PruebaFacil.Models;

namespace PruebaFacil.Controllers
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

        // Acción GET para la vista de edición
        public IActionResult Editar(int id)
        {
            var libro = listaLibros.FirstOrDefault(l => l.Id == id);
            return View(libro);
        }

        // Acción POST para guardar los cambios de edición
        [HttpPost]
        public IActionResult Editar(Libro libro)
        {
            var libroExistente = listaLibros.FirstOrDefault(l => l.Id == libro.Id);
            if (libroExistente != null)
            {
                libroExistente.Titulo = libro.Titulo;
                libroExistente.Autor = libro.Autor;
            }
            return RedirectToAction("Index");
        }

        // Acción para eliminar un libro
        public IActionResult Eliminar(int id)
        {
            var libro = listaLibros.FirstOrDefault(l => l.Id == id);
            if (libro != null)
            {
                listaLibros.Remove(libro);
            }
            return RedirectToAction("Index");
        }
    }
}
