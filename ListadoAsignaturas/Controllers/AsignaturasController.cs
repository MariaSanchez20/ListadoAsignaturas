using ListadoAsignaturas.Models;
using Microsoft.AspNetCore.Mvc;

namespace ListadoAsignaturas.Controllers
{
    public class AsignaturasController : Controller
    {
        public IActionResult Index()
        {
            var asignaturas = new List<Asignatura>
        {
            new Asignatura { NombreAsignatura = "Diseño e Instalación de Redes", NombreProfesor = "Edison Rodríguez", Creditos = 3, Cuatrimestre = 7 },
            new Asignatura { NombreAsignatura = "Programación Avanzada", NombreProfesor = "Santiago", Creditos = 4, Cuatrimestre = 8 },
            new Asignatura { NombreAsignatura = "Circuitos Logicos", NombreProfesor = "Robin", Creditos = 2, Cuatrimestre = 12 },
            new Asignatura { NombreAsignatura = "Teoria de Optimizacion", NombreProfesor = "Ricardo", Creditos = 3, Cuatrimestre = 10 },
            new Asignatura { NombreAsignatura = "Metodos Numericos y Programacion", NombreProfesor = "Genero Rodriguez", Creditos = 3, Cuatrimestre = 10 },
            new Asignatura { NombreAsignatura = "Base de Datos 2", NombreProfesor = "Yahina", Creditos = 3, Cuatrimestre = 7 }


        };
            return View(asignaturas);
        }
    }
}
