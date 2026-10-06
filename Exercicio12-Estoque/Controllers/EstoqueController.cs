using EstoqueMVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace EstoqueMVC.Controllers
{
    public class EstoqueController : Controller
    {
        private readonly List<Produto> produtos = new()
        {
            new Produto {Id=1, Nome="Mouse", Categoria="Informática", Estoque=10, EstoqueMinimo=3, Preco=100},
            new Produto {Id=2, Nome="Teclado", Categoria="Informática", Estoque=2, EstoqueMinimo=3, Preco=200},
            new Produto {Id=3, Nome="Monitor", Categoria="Informática", Estoque=0, EstoqueMinimo=2, Preco=900},
            new Produto {Id=4, Nome="SSD", Categoria="Informática", Estoque=7, EstoqueMinimo=3, Preco=350},
            new Produto {Id=5, Nome="HD", Categoria="Informática", Estoque=1, EstoqueMinimo=2, Preco=300},
            new Produto {Id=6, Nome="Headset", Categoria="Áudio", Estoque=5, EstoqueMinimo=2, Preco=250},
            new Produto {Id=7, Nome="Microfone", Categoria="Áudio", Estoque=0, EstoqueMinimo=2, Preco=350},
            new Produto {Id=8, Nome="Controle", Categoria="Games", Estoque=6, EstoqueMinimo=3, Preco=250},
            new Produto {Id=9, Nome="Mousepad", Categoria="Games", Estoque=12, EstoqueMinimo=5, Preco=70},
            new Produto {Id=10, Nome="Webcam", Categoria="Informática", Estoque=2, EstoqueMinimo=3, Preco=150},
            new Produto {Id=11, Nome="Cabo HDMI", Categoria="Cabos", Estoque=20, EstoqueMinimo=5, Preco=40},
            new Produto {Id=12, Nome="Fonte", Categoria="PC", Estoque=0, EstoqueMinimo=2, Preco=400},
            new Produto {Id=13, Nome="Memória RAM", Categoria="PC", Estoque=4, EstoqueMinimo=3, Preco=250},
            new Produto {Id=14, Nome="Gabinete", Categoria="PC", Estoque=1, EstoqueMinimo=2, Preco=300},
            new Produto {Id=15, Nome="Cooler", Categoria="PC", Estoque=8, EstoqueMinimo=3, Preco=150}
        };
        public IActionResult Index() => View(produtos);
        public IActionResult Baixo() => View("Index", produtos.Where(p => p.Estoque > 0 && p.Estoque <= p.EstoqueMinimo).ToList());
        public IActionResult Esgotados() => View("Index", produtos.Where(p => p.Estoque == 0).ToList());
        public IActionResult Alertas() => View("Index", produtos.Where(p => p.Estoque <= p.EstoqueMinimo).ToList());
    }
}
