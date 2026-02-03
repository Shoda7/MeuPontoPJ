using System;

namespace MeuPontoPJ.Models
{
    public class RegistroPonto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime DataHora { get; set; }
        public string? Tipo { get; set; } // Entrada ou Saída
        public string? Observacao { get; set; }
    }
}