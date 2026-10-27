using AppCursos.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppCursos.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        //incluir DbSet para cada entidade do modelo
        public DbSet<AppCursos.Models.Professor> Professor { get; set; } = default!;
        //incluir DbSet para cada entidade do modelo
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<AlunoTurma> AlunoTurmas { get; set; }

    }


}
