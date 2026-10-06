using Microsoft.AspNetCore.Mvc;
using PedidosMVC.Models;
namespace PedidosMVC.Controllers
{
    public class PedidoController : Controller
    {
        private readonly List<Pedido> pedidos = new()
        {
            new Pedido {Id=1, Cliente="Luiz", Produto="X-Burger", Quantidade=2, PrecoUnitario=20, Status="Recebido"},
            new Pedido {Id=2, Cliente="Ana", Produto="Pizza", Quantidade=1, PrecoUnitario=45, Status="Em preparo"},
            new Pedido {Id=3, Cliente="Lucas", Produto="X-Salada", Quantidade=1, PrecoUnitario=25, Status="Pronto"},
            new Pedido {Id=4, Cliente="Maria", Produto="Batata", Quantidade=2, PrecoUnitario=15, Status="Entregue"},
            new Pedido {Id=5, Cliente="João", Produto="X-Bacon", Quantidade=1, PrecoUnitario=30, Status="Em preparo"},
            new Pedido {Id=6, Cliente="Pedro", Produto="Pizza", Quantidade=2, PrecoUnitario=45, Status="Entregue"},
            new Pedido {Id=7, Cliente="Julia", Produto="X-Burger", Quantidade=1, PrecoUnitario=20, Status="Pronto"},
            new Pedido {Id=8, Cliente="Marcos", Produto="Batata", Quantidade=3, PrecoUnitario=15, Status="Recebido"},
            new Pedido {Id=9, Cliente="Laura", Produto="X-Salada", Quantidade=2, PrecoUnitario=25, Status="Entregue"},
            new Pedido {Id=10, Cliente="Gabriel", Produto="Pizza", Quantidade=1, PrecoUnitario=45, Status="Em preparo"}
        };
        public IActionResult Index() => View(pedidos);
        public IActionResult EmPreparo() => View("Index", pedidos.Where(p => p.Status == "Em preparo").ToList());
        public IActionResult Prontos() => View("Index", pedidos.Where(p => p.Status == "Pronto").ToList());
        public IActionResult Entregues() => View("Index", pedidos.Where(p => p.Status == "Entregue").ToList());
        public IActionResult Resumo()
        {
            ViewBag.TotalPedidos = pedidos.Count;
            ViewBag.ValorTotal = pedidos.Sum(p => p.Total);
            ViewBag.Recebidos = pedidos.Count(p => p.Status == "Recebido");
            ViewBag.EmPreparo = pedidos.Count(p => p.Status == "Em preparo");
            ViewBag.Prontos = pedidos.Count(p => p.Status == "Pronto");
            ViewBag.Entregues = pedidos.Count(p => p.Status == "Entregue");
            return View();
        }
    }
}
