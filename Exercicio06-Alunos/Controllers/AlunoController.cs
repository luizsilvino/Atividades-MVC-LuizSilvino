using AlunosMVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace AlunosMVC.Controllers
{
    public class AlunoController : Controller
    {
        private readonly List<Aluno> alunos = new()
        {
            new Aluno { Id=1, Nome="Luiz", Idade=17, Curso="Desenvolvimento de Sistemas" },
            new Aluno { Id=2, Nome="Marcos", Idade=17, Curso="Administração" },
            new Aluno { Id=3, Nome="Ana", Idade=16, Curso="Mecânica" },
            new Aluno { Id=4, Nome="Lucas", Idade=18, Curso="Eletrônica" },
            new Aluno { Id=5, Nome="Julia", Idade=17, Curso="Desenvolvimento de Sistemas" },
            new Aluno { Id=6, Nome="Pedro", Idade=16, Curso="Administração" },
            new Aluno { Id=7, Nome="Maria", Idade=17, Curso="Eletrônica" },
            new Aluno { Id=8, Nome="João", Idade=18, Curso="Mecânica" }
        };
        public IActionResult Index() => View(alunos);
        public IActionResult Detalhes(int id)
        {
            var aluno = alunos.FirstOrDefault(a => a.Id == id);
            return aluno == null ? NotFound() : View(aluno);
        }
    }
}
