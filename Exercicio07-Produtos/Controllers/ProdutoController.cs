using Microsoft.AspNetCore.Mvc;
using ProdutosMVC.Models;
namespace ProdutosMVC.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly List<Produto> produtos = new()
        {
            new Produto { Id=1, Nome="Mouse", Categoria="Informática", Estoque=10, Preco=80 },
            new Produto { Id=2, Nome="Teclado", Categoria="Informática", Estoque=5, Preco=150 },
            new Produto { Id=3, Nome="Headset", Categoria="Áudio", Estoque=0, Preco=200 },
            new Produto { Id=4, Nome="Monitor", Categoria="Informática", Estoque=3, Preco=900 },
            new Produto { Id=5, Nome="Controle", Categoria="Games", Estoque=8, Preco=250 },
            new Produto { Id=6, Nome="Webcam", Categoria="Informática", Estoque=0, Preco=180 },
            new Produto { Id=7, Nome="Caixa de Som", Categoria="Áudio", Estoque=6, Preco=120 },
            new Produto { Id=8, Nome="Mousepad", Categoria="Games", Estoque=12, Preco=60 },
            new Produto { Id=9, Nome="SSD", Categoria="Informática", Estoque=7, Preco=350 },
            new Produto { Id=10, Nome="Microfone", Categoria="Áudio", Estoque=2, Preco=300 }
        };
        public IActionResult Index() => View(produtos);
        public IActionResult Disponiveis() => View("Index", produtos.Where(p => p.Estoque > 0).ToList());
    }
}
