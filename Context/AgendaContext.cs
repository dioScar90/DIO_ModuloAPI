using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DIO_ModuloAPI.Entities;

namespace DIO_ModuloAPI.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        // Classe no programa que é ao mesmo tempo uma tabela SQL.
        public DbSet<Contato> Contatos { get; set; }
    }
}