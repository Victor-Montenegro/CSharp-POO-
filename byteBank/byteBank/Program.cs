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
            GerenciadorBonificacao gb = new GerenciadorBonificacao();

            Funcionario barbara = new Funcionario();

            barbara.Salario = 2000;

            gb.Registrar(barbara);


            Console.WriteLine(barbara.GetBonificacao());

            Diretor Gabriela = new Diretor();

            Gabriela.Salario = 5000;

            gb.Registrar(Gabriela);


            Funcionario joao = Gabriela;

            //gb.Registrar(joao);

            Console.WriteLine(Gabriela.Salario);
            Console.WriteLine(gb.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
