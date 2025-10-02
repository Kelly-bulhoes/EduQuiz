using Microsoft.AspNetCore.Mvc;

namespace EduQuiz.API.PerguntasNovo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PerguntasController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var perguntas = new[]
            {
                new { Id = 1, Texto = "Qual a capital do Brasil?" },
                new { Id = 2, Texto = "Quanto é 2 + 2?" }
            };

            return Ok(perguntas);
        }
    }
}