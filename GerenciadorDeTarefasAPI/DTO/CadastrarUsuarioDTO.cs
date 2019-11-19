using GerenciadorDeTarefas.Dominio.Entidades;
using GerenciadorDeTarefas.Dominio.Enums;

namespace GerenciadorDeTarefasAPI.DTO
{
    public class CadastrarUsuarioDTO
    {
        public string Usuario { get; set; }
        public string Email { get; set; }
        public int Permissao { get; set; }
        public string Senha { get; set; }

        public static Usuario ParseToEntidade(CadastrarUsuarioDTO dto)
        {
            Usuario usuario = new Usuario();
            usuario.Nome = dto.Usuario;
            usuario.Email = dto.Email;
            usuario.Permissao = (Permissao)dto.Permissao;
            usuario.Senha = dto.Senha;

            return usuario;
        }

         public static CadastrarUsuarioDTO ParseToDTO(Usuario entidade)
        {
            CadastrarUsuarioDTO dto = new CadastrarUsuarioDTO();
            dto.Usuario = entidade.Nome;
            dto.Email = entidade.Email;
            dto.Permissao = (int)entidade.Permissao;
            dto.Senha = entidade.Senha;

            return dto;
        }
    }
}