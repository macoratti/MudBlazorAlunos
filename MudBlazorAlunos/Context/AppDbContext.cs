using Microsoft.EntityFrameworkCore;
using MudBlazorAlunos.Entities;

namespace MudBlazorAlunos.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Aluno> Alunos { get; set; }
}


