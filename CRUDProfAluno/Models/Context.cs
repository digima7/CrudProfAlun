using System.Data.Entity;

namespace CRUDProfAluno.Models
{
    public class Context: DbContext
    {
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
    }
}