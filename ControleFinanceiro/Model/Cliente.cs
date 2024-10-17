using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Model
{
    public class Cliente
    {
        public string Nome {  get;  set; }
        public string Cpf { get; set; }
        public List<Conta> Contas { get; set; }
        public string Telefone { get; set; }
        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public Cliente(string nome, string cpf, string telefone) : this(nome, cpf)
        {
            Telefone = telefone;
        }

        public override string ToString()
        {
            return Nome + " - " + Cpf;
        }
        public decimal SaldoTotalDasContas()
        {
            decimal total = 0;
            foreach (Conta conta in Contas)
            {
                total += conta.Saldo;
            }
            return total;
        }
    }

}
