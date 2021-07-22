using byteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //so posso chamar funcionais static dentro do main, pois o main e static, e so pode receber chamar funcoes statics
            CalcularBonificacao();

            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Designer("123123");
            GerenteDeConta eduardo = new GerenteDeConta("123213123");
            Funcionario gabriela = new Diretor("1231232121");

            gerenciador.Registrar(carlos);
            gerenciador.Registrar(eduardo);
            gerenciador.Registrar(gabriela);

            Console.WriteLine(gerenciador.GetTotalBonificacao());
        }
    }
}
