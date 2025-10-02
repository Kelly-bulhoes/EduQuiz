using EduQuiz.API.PerguntasNovo.Modelos;
using Microsoft.EntityFrameworkCore;

namespace EduQuiz.API.PerguntasNovo.Dados
{
    public class DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configura a relação de 1 para muitos (Uma Pergunta tem muitas Alternativas)
            modelBuilder.Entity<Pergunta>()
                .HasMany(p => p.Alternativas)
                .WithOne(a => a.Pergunta)
                .HasForeignKey(a => a.PerguntaId);

            // Adiciona Dados Iniciais (SEEDING)
            modelBuilder.Entity<Pergunta>().HasData(
                new Pergunta { Id = 1, Texto = "Qual a capital do Brasil?" },
                new Pergunta { Id = 2, Texto = "Qual a maior estrela do sistema solar?" }
            );

            modelBuilder.Entity<Alternativa>().HasData(
                new Alternativa { Id = 1, Texto = "Rio de Janeiro", IsCorreta = false, PerguntaId = 1 },
                new Alternativa { Id = 2, Texto = "Brasília", IsCorreta = true, PerguntaId = 1 },
                new Alternativa { Id = 3, Texto = "São Paulo", IsCorreta = false, PerguntaId = 1 },
                new Alternativa { Id = 4, Texto = "O Sol", IsCorreta = true, PerguntaId = 2 },
                new Alternativa { Id = 5, Texto = "Marte", IsCorreta = false, PerguntaId = 2 },
                new Alternativa { Id = 6, Texto = "Vênus", IsCorreta = false, PerguntaId = 2 }
            );
        }
    }
}