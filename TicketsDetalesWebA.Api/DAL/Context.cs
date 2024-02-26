using Microsoft.EntityFrameworkCore;
using TicketsDetalesWebA.Models;

namespace TicketsDetalesWebA.Api.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Tickets> Tickets { get; set; }

    }
}
