using FluentNHibernate.Mapping;
using GerenciadorDeTarefas.Dominio.Entidades;
using GerenciadorDeTarefas.Dominio.Enums;

namespace GerenciadorDeTarefas.Infraestrutura.Mapeamento
{
    public class UsuarioMap : ClassMap<Usuario>
    {
        public UsuarioMap()
        {
            Table("USUARIO");
            Id(u => u.Id).Column("ID_USUARIO");
            Map(u => u.Nome).Column("NOME");
            Map(u => u.Email).Column("EMAIL");
            Map(u => u.Permissao).Column("PERMISSAO").CustomType<Permissao>();
            Map(u => u.Senha).Column("SENHA");

            HasMany(u => u.Tarefas).KeyColumn("ID_TAREFA");

        }
    }
}