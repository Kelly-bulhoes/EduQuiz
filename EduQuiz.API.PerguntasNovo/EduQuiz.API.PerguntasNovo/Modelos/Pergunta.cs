using System.ComponentModel.DataAnnotations;

namespace EduQuiz.API.PerguntasNovo.Modelos
{
    public class Pergunta
    {
        public Pergunta() { }

        [Key]
        public int Id { get; set; }

        public string? Texto { get; set; }

        public List<Alternativa> Alternativas { get; set; } = new();
    }
}