using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entityes;

namespace ModuloAPI.Context
{
    public class AgendaContext : DbContext  // Classe para ligar o bando de dados ao aplicativo
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        public DbSet<Contato> Contatos{ get; set; } // Propriedade que se refere a entidade (contato) (classe no progama e tabela no sql)
    }
}