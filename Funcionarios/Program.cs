using System;
using System.Collections.Generic;

namespace Funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sistema para cadastrar funcionarios.
            // Será possivel cadastrar hora de entrada e saida de cada funcionário.
            // Gerar report do valor que cada funcionário irá receber ao passar o valor da hora trabalhada.

            List<Funcionario> listaDeFuncionarios = new List<Funcionario>();

            if (false) // Mock
            {
                Funcionario funcionario1 = new Funcionario("Joaoo", 12344321);
                funcionario1.AdicionarHoraTrabalhada("19/9/2021", "7:00", "16:00");
                listaDeFuncionarios.Add(funcionario1);
                listaDeFuncionarios[0].AdicionarHoraTrabalhada("19/9/2021", "7:00", "16:00");
            }


            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- MENU ---");
                Console.WriteLine();
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Cadastrar novo Funcionário.");
                Console.WriteLine("2. Exibir funcionários cadastrados.");
                Console.WriteLine("3. Adicionar hora trabalhada.");
                Console.WriteLine("4. Calcular valor a receber.");
                Console.WriteLine("0. Sair do Programa.");
                int selecionado = Convert.ToInt32(Console.ReadLine());
                
                if (selecionado == 1)
                {
                    Console.Clear();
                    Console.WriteLine("--- Cadastrar novo Funcionário ---");
                    MenuFuncionario.CriarFuncionario(listaDeFuncionarios);
                }
                if (selecionado == 2)
                {
                    Console.Clear();
                    Console.WriteLine("--- Lista de Funcionários ---");
                    MenuFuncionario.ListarFuncionarios(listaDeFuncionarios);
                    MenuFuncionario.EnterToExit();
                }
                if (selecionado == 3)
                {
                    Console.WriteLine("--- Adicionar hora trabalhada ---");
                    Console.WriteLine();
                    MenuFuncionario.AdicionarHora(listaDeFuncionarios);
                }
                if (selecionado == 4)
                {
                    Console.WriteLine("--- Calcular valor a receber ---");
                    MenuFuncionario.CalcularSalario(listaDeFuncionarios);
                    MenuFuncionario.EnterToExit();
                }
                if (selecionado == 0)
                {
                    Console.WriteLine("Finalizando programa...");
                    System.Threading.Thread.Sleep(3000);
                    break;
                }
            }
        }
    }
}
