using System;
using academia.Models;
using Microsoft.EntityFrameworkCore;

namespace academia.Contexto
{
    public class AcademiaDbContext : DbContext
    {
        
        
        public AcademiaDbContext(DbContextOptions<AcademiaDbContext> options) : base(options) { }

        public DbSet<teste> teste { get; set; }
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<StatusPagamento> StatusPagamento { get; set; }
    }
}

