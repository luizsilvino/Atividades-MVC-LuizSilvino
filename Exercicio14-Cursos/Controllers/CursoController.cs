using CursosMVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace CursosMVC.Controllers
{
    public class CursoController : Controller
    {
        private readonly List<Curso> cursos = new()
        {
            new Curso {Id=1, Nome="C#", CargaHoraria=80, Modalidade="Online", Vagas=10, Valor=500},
            new Curso {Id=2, Nome="Java", CargaHoraria=80, Modalidade="Presencial", Vagas=0, Valor=600},
            new Curso {Id=3, Nome="Python", CargaHoraria=60, Modalidade="Online", Vagas=15, Valor=450},
            new Curso {Id=4, Nome="SQL", CargaHoraria=40, Modalidade="Presencial", Vagas=8, Valor=350},
            new Curso {Id=5, Nome="HTML e CSS", CargaHoraria=40, Modalidade="Online", Vagas=20, Valor=300},
            new Curso {Id=6, Nome="JavaScript", CargaHoraria=60, Modalidade="Online", Vagas=0, Valor=400},
            new Curso {Id=7, Nome="Redes", CargaHoraria=80, Modalidade="Presencial", Vagas=5, Valor=550},
            new Curso {Id=8, Nome="Excel", CargaHoraria=30, Modalidade="Online", Vagas=10, Valor=250},
            new Curso {Id=9, Nome="Power BI", CargaHoraria=40, Modalidade="Presencial", Vagas=0, Valor=350},
            new Curso {Id=10, Nome="Git", CargaHoraria=20, Modalidade="Online", Vagas=12, Valor=200}
        };
        public IActionResult Index() => View(cursos);
        public IActionResult Disponiveis() => View("Index", cursos.Where(c => c.Vagas > 0).ToList());
        public IActionResult Online() => View("Index", cursos.Where(c => c.Modalidade == "Online").ToList());
        public IActionResult Presenciais() => View("Index", cursos.Where(c => c.Modalidade == "Presencial").ToList());
        public IActionResult Resumo()
        {
            ViewBag.Total = cursos.Count;
            ViewBag.Disponiveis = cursos.Count(c => c.Vagas > 0);
            ViewBag.Lotados = cursos.Count(c => c.Vagas == 0);
            ViewBag.Online = cursos.Count(c => c.Modalidade == "Online");
            ViewBag.Presenciais = cursos.Count(c => c.Modalidade == "Presencial");
            return View();
        }
    }
}
