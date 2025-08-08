namespace AppTarefas.Models
{
    public class Tarefa
    {
        // Nome da chave primaria deve ser Nome da classe + "Id"
        public int TarefaId { get; set; } //Id é a chave primária 
        public string? Titulo { get; set; }
        public string? Descrição { get; set; }
        public bool Concluida { get; set; }
    }
}
