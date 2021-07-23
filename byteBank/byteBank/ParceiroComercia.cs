using byteBank.Funcionarios;
using byteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank
{
    class ParceiroComercia : IAutenticavel
    {
        public string Senha { get; set; }
        public bool Autentificar(string senha)
        {
            return Senha == senha;
        }
    }
}
