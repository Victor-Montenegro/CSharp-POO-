using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank2.Funcionarios
{
    class GerentenDeConta : Funcionario
    {
        public GerentenDeConta(string cpf) : base(cpf)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificar()
        {
            return Salario * 1.20;
        }
    }
}
