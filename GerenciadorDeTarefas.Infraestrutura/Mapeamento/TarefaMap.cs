using FluentNHibernate.Mapping;
using GerenciadorDeTarefas.Dominio.Entidades;
using GerenciadorDeTarefas.Dominio.Enums;

namespace GerenciadorDeTarefas.Infraestrutura.Mapeamento
{
    public class TarefaMap : ClassMap<Tarefa>
    {
        public TarefaMap()
        {
            Table("TAREFA");
            Id(t => t.Id).Column("ID_TAREFA");
            Map(t => t.Nome).Column("NOME");
            Map(t => t.Status).Column("STATUS").CustomType<StatusTarefa>();

            References(t => t.Usuario).Column("ID_USUARIO");
        }
    }
}