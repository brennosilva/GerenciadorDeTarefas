using GerenciadorDeTarefas.Dominio.Enums;

namespace GerenciadorDeTarefasAPI.DTO
{
    public class LoginDTO
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public int Permissao { get; set; }


    }
}