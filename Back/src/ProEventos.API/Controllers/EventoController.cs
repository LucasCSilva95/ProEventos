using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly IEnumerable<Evento> _evento = new Evento[] {
            new Evento() {
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "São Paulo",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "foto.png"
            },
            new Evento() {
                EventoId = 2,
                Tema = "teste",
                Local = "RJ",
                Lote = "2º Lote",
                QtdPessoas = 300,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png"
            },
        };

        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(e => e.EventoId == id);
        }


        [HttpPost]
        public string Post()
        {
            return "POST value";
        }
        
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"PUT id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"DELET id = {id}";
        }
    }
}