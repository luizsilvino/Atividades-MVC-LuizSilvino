namespace FuncionariosMVC.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public string Cargo { get; set; } = "";
        public string Departamento { get; set; } = "";
        public decimal Salario { get; set; }
        public bool Ativo { get; set; }

        public string Situacao => Ativo ? "Funcionário ativo" : "Funcionário desligado";

        public string FaixaSalarial =>
            Salario < 2500 ? "Faixa 1" :
            Salario <= 5000 ? "Faixa 2" :
            "Faixa 3";
    }
}
