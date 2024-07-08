using System.ComponentModel.DataAnnotations;

namespace Microondas_Digital.Models
{
    public class Programas
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do Programa")]
        [MaxLength(100)]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "Digite o nome da Comida")]
        [MaxLength(100)]
        public required string Comida { get; set; }

        [Required(ErrorMessage = "Digite o tempo em segundos")]
        [Range(1, int.MaxValue, ErrorMessage = "O tempo em segundos deve ser um valor positivo")]
        public int TempoEmSegundos { get; set; }

        [Required(ErrorMessage = "Selecione a potência")]
        public int Potencia { get; set; }

        [Required(ErrorMessage = "Digite um caractere não usado anteriormente")]
        [MaxLength(1)]
        public required string CaracterDeAquecimento { get; set; }

        public required string Instrucoes { get; set; }

        public bool Customizado { get; set; }
    }
}
