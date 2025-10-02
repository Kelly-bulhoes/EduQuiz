using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EduQuiz.API.PerguntasNovo.Modelos
{
    public class Alternativa
    {
        public Alternativa() { }

        [Key]
        public int Id { get; set; }

        public string? Texto { get; set; }

        public bool IsCorreta { get; set; }

        [JsonIgnore]
        public Pergunta? Pergunta { get; set; }

        public int PerguntaId { get; set; }
    }
}