using list.Model;
using Microsoft.EntityFrameworkCore;

namespace list.Data

{
    public class AlunoContext : DbContext
    {
        public AlunoContext(DbContextOptions<AlunoContext> options) : base(options)
        {
        }

        private DbSet<Aluno> aluno;

        public DbSet<Aluno> GetAluno()
        {
            return aluno;
        }

        public void SetAluno(DbSet<Aluno> value)
        {
            aluno = value;
        }

        public DbSet<list.Model.Aluno> Aluno { get; set; }
    }
}