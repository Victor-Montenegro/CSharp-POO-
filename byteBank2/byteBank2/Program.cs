using byteBank2.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank2
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistrarBonificacao();

            Console.ReadLine();
        }

        public static void RegistrarBonificacao()
        {
            GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

            Funcionario douglas = new Diretor("12312312312");
            Funcionario samuel = new Desenvolvedor("123213123213");
            Funcionario Helena = new Designer("12323222");

            gerenciador.Registrar(douglas);
            gerenciador.Registrar(samuel);
            gerenciador.Registrar(Helena);

            Console.WriteLine(gerenciador.GetTotalDeBonificacao());
        }

    }

}
