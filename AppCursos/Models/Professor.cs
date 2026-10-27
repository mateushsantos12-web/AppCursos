namespace AppCursos.Models
{
    public class Professor
    {
        public int Id { get; set; } //chave primaria (Primary Key)
        public string Nome { get; set; }
        public string Email { get; set; }
        public decimal Salario { get; set; }
    }
}
