using System.ComponentModel.DataAnnotations;

namespace Microondas_Digital.Models
{
    public class Programas
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public required string Nome { get; set; }

        [Required]
        [MaxLength(100)]
        public required string Comida { get; set; }

        [Required]
        public int TempoEmSegundos { get; set; }

        [Required]
        public int Potencia { get; set; }

        [Required]
        [MaxLength(1)]
        public required string CaracterDeAquecimento { get; set; }

        public required string Instrucoes { get; set; }

        public bool Customizado { get; set; }
    }
}
