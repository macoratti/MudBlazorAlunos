using MudBlazorAlunos.Entities;

namespace MudBlazorAlunos.Services;

public interface IAlunoService
{
    Task<IEnumerable<Aluno>> GetAlunos();
    Task<Aluno> GetAlunoPorId(int id);
    Task SalvarAluno(Aluno aluno);
    Task DeletarAluno(int id);

}
