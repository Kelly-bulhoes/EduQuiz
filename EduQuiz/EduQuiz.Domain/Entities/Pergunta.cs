namespace EduQUIZ.Domain.Entities
{
    public class Pergunta
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public List<Resposta> Respostas { get; set; } = new();
    }
}