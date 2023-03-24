using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModuloAPI.Entityes;
using ModuloAPI.Context;

namespace ModuloAPI.Controllers // Classe criada para controlar a iserção de dados 
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context;
        }
        
        // Abaixo End.Point criado para Criar um novo contato
        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new {id = contato.Id}, contato);
        }

        // Abaixo um endPoint criado para buscar um contato atraves de uma Id
        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var contato = _context.Contatos.Find(id);
            
            // Abaixo validadação, para se inserir contato nulo.
            if (contato == null)
                return NotFound();
            
            return Ok(contato);
        }

        //Abaixo um EndPoint criado para buscra um contato pelo nome.
        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(string nome)
        {
            var contatos = _context.Contatos.Where(x => x.Nome.Contains(nome)); 
            return Ok(contatos);
        }

        
        // Abaixo um EndPoint criado para atualizar uma linha da tabela - indicado por um Id
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);
            
            // Abaixo validadação, para se inserir contato nulo.
            if (contato == null)
                return NotFound();

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return  Ok(contatoBanco);
            
            return Ok(contato);
        }


        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var contato = _context.Contatos.Find(id);
            
            // Abaixo validadação, para se inserir contato nulo.
            if (contato == null)
                return NotFound();
            
            //_context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();
            return NoContent(); //<< NoContent significa sem conteudo
        }

        
    }
}