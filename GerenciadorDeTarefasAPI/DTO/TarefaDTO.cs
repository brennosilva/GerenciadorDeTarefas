using System.Collections.Generic;
using GerenciadorDeTarefas.Dominio.Entidades;

namespace GerenciadorDeTarefasAPI.DTO
{
    public class TarefaDTO
    {
        public TarefaDTO()
        {
        }

        public TarefaDTO(string nome, int idUsuario, int status, int id)
        {
            Id = id;
            Nome = nome;
            IdUsuario = idUsuario;
            Status = status;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdUsuario { get; set; }
        public int Status { get; set; }

        public static IList<TarefaDTO> parseDTO(IList<Tarefa> tarefas)
        {
            IList<TarefaDTO> dto = new List<TarefaDTO>();
            foreach (var item in tarefas)
            {
                dto.Add(new TarefaDTO(item.Nome, item.Usuario.Id, (int)item.Status, item.Id));
            }
            return dto;
        }
    }


}