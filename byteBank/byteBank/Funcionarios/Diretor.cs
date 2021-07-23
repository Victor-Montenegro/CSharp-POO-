using byteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {

        public Diretor(string cpf) : base(5000,cpf)
        {

        }
        public override double GetBonificacao()
        {
                                        // realizando chamada das funções,metodos da class pai, se caso o metedo nao fosse abstract
            return Salario * 1.10; //base.GetBonificacao()
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
