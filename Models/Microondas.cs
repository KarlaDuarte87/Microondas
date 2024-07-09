using System;
using System.Threading;

namespace Microondas_Digital.Models
{
    public class Microondas
    {
        public void IniciarAquecimento(int tempoEmSegundos, int potencia = 10)
        {
            if (tempoEmSegundos < 1 || tempoEmSegundos > 120)
            {
                throw new ArgumentOutOfRangeException(nameof(tempoEmSegundos), "O tempo deve estar entre 1 segundo e 2 minutos (120 segundos).");
            }

            if (potencia < 1 || potencia > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(potencia), "A potência deve estar entre 1 e 10.");
            }

            string tempoFormatado = FormatTime(tempoEmSegundos);

            Console.WriteLine($"Iniciando aquecimento por {tempoFormatado} na potência {potencia}.");

            for (int i = 0; i < tempoEmSegundos; i++)
            {
                Console.WriteLine($"Aquecendo... {i + 1} segundos.");
                Thread.Sleep(1000); 
            }

            Console.WriteLine("Aquecimento concluído!");
        }

        private string FormatTime(int tempoEmSegundos)
        {
            if (tempoEmSegundos < 60 || tempoEmSegundos >= 100)
            {
                return $"{tempoEmSegundos} segundos";
            }

            int minutos = tempoEmSegundos / 60;
            int segundos = tempoEmSegundos % 60;
            return $"{minutos}:{segundos:D2} minutos";
        }
    }
}
