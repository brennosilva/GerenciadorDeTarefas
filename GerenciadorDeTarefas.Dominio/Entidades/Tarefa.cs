using GerenciadorDeTarefas.Dominio.Enums;

namespace GerenciadorDeTarefas.Dominio.Entidades
{
    public class Tarefa
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual StatusTarefa Status { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}