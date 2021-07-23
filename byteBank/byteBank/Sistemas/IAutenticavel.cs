using byteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank.Sistemas
{
    public interface IAutenticavel 
    {
        bool Autentificar(string senha);
    }
}
