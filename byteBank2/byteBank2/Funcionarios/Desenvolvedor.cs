using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank2.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(cpf, 4000)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }

        public override double GetBonificar()
        {
            return Salario * 1.15;
        }
    }
}
