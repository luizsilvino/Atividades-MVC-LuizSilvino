using BibliotecaMVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace BibliotecaMVC.Controllers
{
    public class BibliotecaController : Controller
    {
        private readonly List<Livro> livros = new()
        {
            new Livro {Id=1,Titulo="Dom Casmurro",Autor="Machado de Assis",Ano=1899,Disponivel=true},
            new Livro {Id=2,Titulo="O Hobbit",Autor="J.R.R. Tolkien",Ano=1937,Disponivel=true},
            new Livro {Id=3,Titulo="1984",Autor="George Orwell",Ano=1949,Disponivel=false},
            new Livro {Id=4,Titulo="Harry Potter",Autor="J.K. Rowling",Ano=1997,Disponivel=true},
            new Livro {Id=5,Titulo="It",Autor="Stephen King",Ano=1986,Disponivel=false},
            new Livro {Id=6,Titulo="Drácula",Autor="Bram Stoker",Ano=1897,Disponivel=true},
            new Livro {Id=7,Titulo="Duna",Autor="Frank Herbert",Ano=1965,Disponivel=true},
            new Livro {Id=8,Titulo="Coraline",Autor="Neil Gaiman",Ano=2002,Disponivel=false},
            new Livro {Id=9,Titulo="Hamlet",Autor="William Shakespeare",Ano=1603,Disponivel=true},
            new Livro {Id=10,Titulo="Frankenstein",Autor="Mary Shelley",Ano=1818,Disponivel=true}
        };
        public IActionResult Index() => View(livros);
        public IActionResult Disponiveis() => View("Index", livros.Where(l => l.Disponivel).ToList());
    }
}
