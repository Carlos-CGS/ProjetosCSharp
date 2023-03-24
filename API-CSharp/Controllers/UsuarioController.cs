using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ModuloAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase // << Nome da nova API (Usuario)
    {
        [HttpGet("ObterDataHoraAtualy")] // << Nome do método que é disponibilizado externamente
        public IActionResult ObterDataHora() // << Método em si, que é executado.
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };
            return Ok(obj); // <, retoino do método (Return OK(Obj) onde o Ok é um método HTTP
        }
        
        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Olá {nome}, seja bem vindo!";
            return Ok(new {mensagem} );
        }
    }
}