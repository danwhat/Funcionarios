using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class MenuFuncionario
    {

        public static void EnterToExit()
        {
            Console.WriteLine();
            Console.WriteLine("Tecle ENTER para voltar ao menu.");
            Console.ReadLine();
        }
        public static void CriarFuncionario(List<Funcionario> lista)
        {
            Console.Write("Escreva o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.Write("Escreva o CPF do funcionário (apenas números): ");
            int cpf = Convert.ToInt32(Console.ReadLine());

            Funcionario funcionario = new Funcionario(nome, cpf);
            lista.Add(funcionario);
        }
        public static void ListarFuncionarios(List<Funcionario> lista)
        {

            if (lista.Count == 0)
            {
                Console.WriteLine("Não há funcionários cadastrados");
            }
            else
            {
                int funcionarioNumero = 1;
                foreach (Funcionario funcionario in lista)
                {
                    Console.WriteLine($"{funcionarioNumero} - {funcionario.Nome}");
                    funcionarioNumero++;
                }
            }
        }
        public static void AdicionarHora(List<Funcionario> lista)
        {
            Console.Write("digite o numero do funcionário: ");
            int numeroFuncionario = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write($"Funcionário {lista[numeroFuncionario].Nome} selecionado.");

            Console.WriteLine();
            Console.WriteLine("digite a data: (formato 5/9/2019)");
            string data = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("digite a hora de entrada: (formato 00:00)");
            string entrada = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("digite a hora de saida: (formato 00:00)");
            string saida = Console.ReadLine();

            lista[numeroFuncionario].AdicionarHoraTrabalhada(data, entrada, saida);
        }
        public static void CalcularSalario(List<Funcionario> lista)
        {
            Console.Write("digite o valor da hora de trabalho: ");
            int valorHora = Convert.ToInt32(Console.ReadLine());
            foreach (Funcionario funcionario in lista)
            {
                Console.WriteLine($"{funcionario.Nome} receberá R${funcionario.GetHorasTrabalhadas() * valorHora} pelos serviços prestados.");
            }
        }
    }
}
