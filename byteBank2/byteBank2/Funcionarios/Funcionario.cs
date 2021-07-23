using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank2.Funcionarios
{
    public abstract class Funcionario
    {

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public int TotalDeFuncionarios { get; set; }

        public Funcionario(string cpf, double salario)
        {
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        public Funcionario(string cpf) : this(cpf, 1500)
        {

        }

        public abstract double GetBonificar();
        public abstract void AumentarSalario();
    }
}
