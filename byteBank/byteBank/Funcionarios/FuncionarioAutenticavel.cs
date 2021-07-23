using byteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf)
        {

        }

        public string Senha { get; set; }
        public bool Autentificar(string senha)
        {
            return Senha == senha;
        }
    }
}

