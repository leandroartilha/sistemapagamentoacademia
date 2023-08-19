using System;
using System.ComponentModel.DataAnnotations;

namespace academia.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Nome { get; set; }

        [MaxLength(20)]
        public string? Telefone { get; set; }

        [DataType(DataType.Currency)]
        public decimal? Valor { get; set; }
        public DateTime? DataMensalidade { get; set; }
        public bool? Inativo { get; set; }

        public int? DiaPagamento { get; set; }

        public DateTime? DataCadastro { get; set; }

        public int? StatusPagamentoId { get; set; }
        public StatusPagamento? StatusPagamento { get; set; }
    }
}

