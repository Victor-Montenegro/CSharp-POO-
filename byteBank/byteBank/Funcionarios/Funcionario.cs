﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionario { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario,string cpf)
        {
            Salario = salario;
            CPF = cpf;
            TotalDeFuncionario++;
        }

        public Funcionario(string cpf) : this(1500, cpf)
        {

        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
    }
}
