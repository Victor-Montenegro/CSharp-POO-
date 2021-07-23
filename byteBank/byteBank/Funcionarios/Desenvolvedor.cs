using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank.Funcionarios
{
    class Desenvolvedor : Funcionario
    {

        public Desenvolvedor(string cpf) : base(cpf)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.25;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.15;
        }
    }
}
