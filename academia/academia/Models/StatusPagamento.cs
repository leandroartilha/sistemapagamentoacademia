using System;
namespace academia.Models
{
    public class StatusPagamento
    {
        public int Id { get; set; }
        public string NomeStatusPagamento { get; set; }
        public ICollection<Aluno> Aluno { get; set; }
    }
}

