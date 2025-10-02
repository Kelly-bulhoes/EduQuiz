using System.Collections.Generic;

namespace EduQUIZ.Domain.Entities
{
    public class Pergunta
    {
        public int Id { get; set; }
        public string Enunciado { get; set; }
        public List<Resposta> Respostas { get; set; } = new List<Resposta>();
    }
}