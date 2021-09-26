using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class Funcionario
    {
        public string Nome { get; set; }

        public int CPF { get; set; }
        
        List<HoraTrabalhada> HorasTrabalhadas = new List<HoraTrabalhada>();

        public Funcionario(string nome, int cPF)
        {
            Nome = nome;
            CPF = cPF;
        }

        public void AdicionarHoraTrabalhada(string dataString, string horaEntradaString, string horaSaidaString)
        {
            DateTime horaEntrada = DateTime.Parse($"{dataString} {horaEntradaString}");
            DateTime horaSaida = DateTime.Parse($"{dataString} {horaSaidaString}");
            HoraTrabalhada horaTrabalhada = new HoraTrabalhada(horaEntrada, horaSaida);
            HorasTrabalhadas.Add(horaTrabalhada);
        }

        public double GetHorasTrabalhadas()
        {
            double total = 0;
            foreach (HoraTrabalhada horaTrabalhada in HorasTrabalhadas)
            {
                total += horaTrabalhada.GetHorasTrabalhadas();
            }
            return total;
        }
    }
}
