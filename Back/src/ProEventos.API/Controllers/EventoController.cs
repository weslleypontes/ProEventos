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

        public IEnumerable<Evento> _evento = new Evento[]
            {
                new Evento()
                { 
                    EventoId = 1,
                    Local = "Setor D1",
                    //Vai pegar a data atual e somar mais 2 dias.
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    Tema = "EBD",
                    QtdPessoas = 50,
                    Lote = "1º Lote",
                    ImagemURL = "C/projeetos"
                },
                new Evento()
                { 
                    EventoId = 2,
                    Local = "Paraipaba",
                    //Vai pegar a data atual e somar mais 2 dias.
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    Tema = "Compras",
                    QtdPessoas = 2,
                    Lote = "1º Lote",
                    ImagemURL = "C/projeetos"
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
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(e => e.EventoId == id);
        }

        [HttpPost]
        public string Post(string nome)
        {
            return $"Exemplo de Post, retornando {nome}";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}
