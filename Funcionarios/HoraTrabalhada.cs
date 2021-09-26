using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class HoraTrabalhada
    {
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSaida { get; set; }

        public HoraTrabalhada(string dataString, string horaEntradaString, string horaSaidaString)
        {
            // String Exemplo para o DateTime.Parse: "5/9/2019 14:15:33"
            HoraEntrada = DateTime.Parse($"{dataString} {horaEntradaString}");
            HoraSaida = DateTime.Parse($"{dataString} {horaSaidaString}");
        }

        public HoraTrabalhada(DateTime horaEntrada, DateTime horaSaida)
        {
            HoraEntrada = horaEntrada;
            HoraSaida = horaSaida;
        }

        public double GetHorasTrabalhadas()
        {
            return (HoraSaida - HoraEntrada).TotalSeconds / 60 / 60;
        }
    }
}
