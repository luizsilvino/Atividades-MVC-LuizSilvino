using FuncionariosMVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace FuncionariosMVC.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly List<Funcionario> funcionarios = new()
        {
            new Funcionario {Id=1, Nome="Luiz", Cargo="Programador", Departamento="TI", Salario=4500, Ativo=true},
            new Funcionario {Id=2, Nome="Ana", Cargo="Analista", Departamento="TI", Salario=5200, Ativo=true},
            new Funcionario {Id=3, Nome="Lucas", Cargo="Auxiliar", Departamento="RH", Salario=2200, Ativo=true},
            new Funcionario {Id=4, Nome="Maria", Cargo="Gerente", Departamento="RH", Salario=6500, Ativo=true},
            new Funcionario {Id=5, Nome="Pedro", Cargo="Vendedor", Departamento="Vendas", Salario=2800, Ativo=false},
            new Funcionario {Id=6, Nome="Julia", Cargo="Vendedora", Departamento="Vendas", Salario=3000, Ativo=true},
            new Funcionario {Id=7, Nome="João", Cargo="Técnico", Departamento="TI", Salario=3500, Ativo=true},
            new Funcionario {Id=8, Nome="Marcos", Cargo="Auxiliar", Departamento="Financeiro", Salario=2300, Ativo=false},
            new Funcionario {Id=9, Nome="Laura", Cargo="Analista", Departamento="Financeiro", Salario=4800, Ativo=true},
            new Funcionario {Id=10, Nome="Gabriel", Cargo="Supervisor", Departamento="Vendas", Salario=5500, Ativo=true},
            new Funcionario {Id=11, Nome="Bianca", Cargo="Recepcionista", Departamento="RH", Salario=2100, Ativo=true},
            new Funcionario {Id=12, Nome="Matheus", Cargo="Programador", Departamento="TI", Salario=4200, Ativo=false},
            new Funcionario {Id=13, Nome="Rafael", Cargo="Gerente", Departamento="Financeiro", Salario=7000, Ativo=true},
            new Funcionario {Id=14, Nome="Beatriz", Cargo="Vendedora", Departamento="Vendas", Salario=2700, Ativo=true},
            new Funcionario {Id=15, Nome="Carlos", Cargo="Técnico", Departamento="TI", Salario=3200, Ativo=true}
        };

        public IActionResult Index() => View(funcionarios);
        public IActionResult Ativos() => View("Index", funcionarios.Where(f => f.Ativo).ToList());
        public IActionResult Inativos() => View("Index", funcionarios.Where(f => !f.Ativo).ToList());
        public IActionResult Departamento(string id) =>
            View("Index", funcionarios.Where(f => f.Departamento.Equals(id ?? "", StringComparison.OrdinalIgnoreCase)).ToList());

        public IActionResult Dashboard()
        {
            ViewBag.Total = funcionarios.Count;
            ViewBag.Ativos = funcionarios.Count(f => f.Ativo);
            ViewBag.Inativos = funcionarios.Count(f => !f.Ativo);
            ViewBag.TI = funcionarios.Count(f => f.Departamento == "TI");
            ViewBag.RH = funcionarios.Count(f => f.Departamento == "RH");
            ViewBag.Vendas = funcionarios.Count(f => f.Departamento == "Vendas");
            ViewBag.Financeiro = funcionarios.Count(f => f.Departamento == "Financeiro");
            ViewBag.Media = funcionarios.Average(f => f.Salario);
            ViewBag.Maior = funcionarios.Max(f => f.Salario);
            ViewBag.Menor = funcionarios.Min(f => f.Salario);
            return View();
        }
    }
}
