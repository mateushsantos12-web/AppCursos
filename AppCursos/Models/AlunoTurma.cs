namespace AppCursos.Models
{
    public class AlunoTurma
    {
        public int Id { get; set; } //chave primaria (Primary Key)
        public int AlunoId { get; set; } //chave estrangeira (Foreign Key)
        public Aluno Aluno { get; set; } //propriedade de navegação
        public int TurmaId { get; set; } //chave estrangeira (Foreign Key)
        public Turma Turma { get; set; } //propriedade de navegação
    }
}
