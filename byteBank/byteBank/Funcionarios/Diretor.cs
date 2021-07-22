﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank.Funcionarios
{
    public class Diretor : Funcionario
    {

        public Diretor(string cpf) : base(5000,cpf)
        {

        }
        public override double GetBonificacao()
        {
                             // realizando chamada das funções,metodos da class pai
            return Salario + base.GetBonificacao();
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
