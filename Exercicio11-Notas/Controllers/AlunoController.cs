using Microsoft.AspNetCore.Mvc;
using NotasMVC.Models;
namespace NotasMVC.Controllers
{
    public class AlunoController : Controller
    {
        private readonly List<Aluno> alunos = new()
        {
            new Aluno {Id=1, Nome="Luiz", Curso="DS", Nota1=8, Nota2=7, Nota3=9},
            new Aluno {Id=2, Nome="Ana", Curso="DS", Nota1=5, Nota2=4, Nota3=5},
            new Aluno {Id=3, Nome="Lucas", Curso="DS", Nota1=2, Nota2=3, Nota3=3},
            new Aluno {Id=4, Nome="Pedro", Curso="ADM", Nota1=7, Nota2=8, Nota3=6},
            new Aluno {Id=5, Nome="Julia", Curso="ADM", Nota1=5, Nota2=5, Nota3=4},
            new Aluno {Id=6, Nome="Maria", Curso="DS", Nota1=9, Nota2=8, Nota3=10},
            new Aluno {Id=7, Nome="João", Curso="Mecânica", Nota1=3, Nota2=2, Nota3=4},
            new Aluno {Id=8, Nome="Marcos", Curso="DS", Nota1=6, Nota2=7, Nota3=6},
            new Aluno {Id=9, Nome="Gabriel", Curso="ADM", Nota1=4, Nota2=5, Nota3=5},
            new Aluno {Id=10, Nome="Laura", Curso="DS", Nota1=10, Nota2=9, Nota3=9}
        };
        public IActionResult Index() => View(alunos);
        public IActionResult Aprovados() => View("Index", alunos.Where(a => a.Media >= 6).ToList());
        public IActionResult Recuperacao() => View("Index", alunos.Where(a => a.Media >= 4 && a.Media < 6).ToList());
        public IActionResult Reprovados() => View("Index", alunos.Where(a => a.Media < 4).ToList());
    }
}
