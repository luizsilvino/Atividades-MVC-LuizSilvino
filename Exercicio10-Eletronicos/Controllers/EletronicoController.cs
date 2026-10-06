using EletronicosMVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace EletronicosMVC.Controllers
{
    public class EletronicoController : Controller
    {
        private readonly List<Eletronico> produtos = new()
        {
            new Eletronico {Id=1, Nome="TV", Marca="Samsung", Categoria="TV", Preco=2500, Estoque=5},
            new Eletronico {Id=2, Nome="Galaxy S", Marca="Samsung", Categoria="Celular", Preco=3000, Estoque=3},
            new Eletronico {Id=3, Nome="iPhone", Marca="Apple", Categoria="Celular", Preco=5000, Estoque=2},
            new Eletronico {Id=4, Nome="Notebook", Marca="Dell", Categoria="Computador", Preco=4000, Estoque=4},
            new Eletronico {Id=5, Nome="Monitor", Marca="LG", Categoria="Computador", Preco=900, Estoque=8},
            new Eletronico {Id=6, Nome="Headset", Marca="HyperX", Categoria="Acessório", Preco=300, Estoque=0},
            new Eletronico {Id=7, Nome="Mouse", Marca="Logitech", Categoria="Acessório", Preco=150, Estoque=10},
            new Eletronico {Id=8, Nome="Teclado", Marca="Redragon", Categoria="Acessório", Preco=250, Estoque=0},
            new Eletronico {Id=9, Nome="PS5", Marca="Sony", Categoria="Console", Preco=3500, Estoque=2},
            new Eletronico {Id=10, Nome="Xbox", Marca="Microsoft", Categoria="Console", Preco=3200, Estoque=3},
            new Eletronico {Id=11, Nome="Tablet", Marca="Samsung", Categoria="Tablet", Preco=1800, Estoque=4},
            new Eletronico {Id=12, Nome="Smartwatch", Marca="Xiaomi", Categoria="Acessório", Preco=500, Estoque=6}
        };
        public IActionResult Index() => View(produtos);
        public IActionResult EmEstoque() => View("Index", produtos.Where(p => p.Estoque > 0).ToList());
        public IActionResult Categoria(string id) => View("Index", produtos.Where(p => p.Categoria.Equals(id ?? "", StringComparison.OrdinalIgnoreCase)).ToList());
        public IActionResult Baratos() => View("Index", produtos.Where(p => p.Preco < 1000).ToList());
    }
}
