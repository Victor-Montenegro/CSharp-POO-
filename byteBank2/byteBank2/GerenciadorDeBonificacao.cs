using byteBank2.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank2
{
    public class GerenciadorDeBonificacao
    {

        private double _totalDeBonificacao;

        public double TotalDeBonificacao
        {
            get
            {
                return _totalDeBonificacao;
            }
            private set
            {
                _totalDeBonificacao += value;
            }
        }

        public void Registrar(Funcionario funcionario)
        {
            TotalDeBonificacao = funcionario.GetBonificar();
        }

        public double GetTotalDeBonificacao()
        {
            return TotalDeBonificacao;
        }
    }
}
