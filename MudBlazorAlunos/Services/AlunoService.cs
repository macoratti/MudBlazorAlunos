using Microsoft.EntityFrameworkCore;
using MudBlazorAlunos.Context;
using MudBlazorAlunos.Entities;

namespace MudBlazorAlunos.Services;

public class AlunoService : IAlunoService
{
    private readonly AppDbContext _context;
    public AlunoService(AppDbContext context)
    {
        _context = context;
    }

    public async Task DeletarAluno(int id)
    {
        var aluno = await _context.Alunos.FindAsync(id);
        if (aluno != null)
        {
            _context.Alunos.Remove(aluno);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<Aluno> GetAlunoPorId(int id)
    {
        var aluno = await _context.Alunos.FindAsync(id);
        return aluno!;
    }

    public async Task<IEnumerable<Aluno>> GetAlunos()
    {
        return await _context.Alunos.ToListAsync();
    }

    public async Task SalvarAluno(Aluno aluno)
    {
        if (aluno.Id == 0)
        {
            await _context.Alunos.AddAsync(aluno);
        }
        else
        {
            _context.Alunos.Update(aluno);
        }
        await _context.SaveChangesAsync();
    }
}
