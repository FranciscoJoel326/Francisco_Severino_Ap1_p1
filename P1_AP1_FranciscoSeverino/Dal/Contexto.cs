using Microsoft.EntityFrameworkCore;
using P1_AP1_FranciscoSeverino.Models;

namespace P1_AP1_FranciscoSeverino.Dal;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    public DbSet<Autores> Autores { get; set; }
}
