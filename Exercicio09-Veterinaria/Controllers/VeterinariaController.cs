using Microsoft.AspNetCore.Mvc;
using VeterinariaMVC.Models;
namespace VeterinariaMVC.Controllers
{
    public class VeterinariaController : Controller
    {
        private readonly List<Animal> animais = new()
        {
            new Animal {Id=1, Nome="Thor", Especie="Cachorro", Idade=4, Dono="Luiz"},
            new Animal {Id=2, Nome="Mel", Especie="Gato", Idade=2, Dono="Ana"},
            new Animal {Id=3, Nome="Bob", Especie="Cachorro", Idade=5, Dono="Lucas"},
            new Animal {Id=4, Nome="Luna", Especie="Gato", Idade=3, Dono="Maria"},
            new Animal {Id=5, Nome="Zeus", Especie="Cachorro", Idade=6, Dono="Pedro"},
            new Animal {Id=6, Nome="Mia", Especie="Gato", Idade=1, Dono="Julia"},
            new Animal {Id=7, Nome="Max", Especie="Cachorro", Idade=7, Dono="João"},
            new Animal {Id=8, Nome="Nina", Especie="Gato", Idade=4, Dono="Marcos"}
        };
        public IActionResult Index() => View(animais);
        public IActionResult Cachorros() => View("Index", animais.Where(a => a.Especie == "Cachorro").ToList());
        public IActionResult Gatos() => View("Index", animais.Where(a => a.Especie == "Gato").ToList());
    }
}
