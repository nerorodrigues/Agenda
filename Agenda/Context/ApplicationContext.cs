using Agenda.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext():base("Server=localhost;Database=Agenda;User Id=agenda;Password=123456;")
        {

        }

        public DbSet<Compromisso> Compromisso { get; set; }
    }
}
