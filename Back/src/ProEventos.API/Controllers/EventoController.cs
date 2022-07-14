using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento>  _evento = new Evento[]{
            new Evento() {
                EventoId = 1,
                Tema = ".Net",
                Local = "São Paulo",
                Lote = " 1º Lote",
                QtdPessoas = 200,
                DataEvento = DateTime.Now.AddDays(5).ToString("dd/MM/yyyy"),
                ImagemURL = "Foto.png"
                },
            new Evento (){
                EventoId = 2,
                Tema = ".Net 5",
                Local = "São Paulo",
                Lote = " 1º Lote",
                QtdPessoas = 280,
                DataEvento = DateTime.Now.AddDays(15).ToString("dd/MM/yyyy"),
                ImagemURL = "Foto2.png"
                }
        };

        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }        

        [HttpGet ("{id}")]
        public Evento GetById(int id){
            return _evento.FirstOrDefault(x => x.EventoId == id);
        }

        
    }
}
