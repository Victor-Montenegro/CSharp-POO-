using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Autentificacao(IAutenticavel funcionario, string senha)
        {
            bool usuarioAtenticavel = funcionario.Autentificar(senha);

            if (!usuarioAtenticavel)
            {
                Console.WriteLine("Senha ou usuario incorreto!");
                return false;
            }

            Console.WriteLine("Bem vindo ao sistema!");
            return true;
        }
    }
}
