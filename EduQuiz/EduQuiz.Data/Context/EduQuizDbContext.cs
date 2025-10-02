using Microsoft.EntityFrameworkCore;
using EduQUIZ.Domain.Entities;

namespace EduQUIZ.Data.Context
{
    public class EduQuizDbContext : DbContext
    {
        public EduQuizDbContext(DbContextOptions<EduQuizDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pergunta> Perguntas { get; set; }
        public DbSet<Resposta> Respostas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pergunta>()
                .HasMany(p => p.Respostas)
                .WithOne(r => r.Pergunta)
                .HasForeignKey(r => r.PerguntaId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
