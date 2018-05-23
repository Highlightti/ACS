using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationClinicalSystem.br.com.acs.model
{
    class Usuario
    {
        public int idUsuario { get; set; }
        public string tipoUsuario { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string emailGrupo { get; set; }
        public string senha { get; set; }
        public int statusUsuario { get; set; }
        public DateTime dataModificacao { get; set; }
        public int usuarioModificacao { get; set; }
        public int idUsuarioLogado { get; set; }
        public string usuarioException { get; set; }

        public Usuario() { }

        public Usuario(int idUsuario, string tipoUsuario, string nome, string email, string emailGrupo, string senha, int statusUsuario, DateTime dataModificacao, int usuarioModificacao, string usuarioException)
        {
            this.idUsuario = idUsuario;
            this.tipoUsuario = tipoUsuario;
            this.nome = nome;
            this.email = email;
            this.emailGrupo = emailGrupo;
            this.senha = senha;
            this.statusUsuario = statusUsuario;
            this.dataModificacao = dataModificacao;
            this.usuarioModificacao = usuarioModificacao;
            this.idUsuarioLogado = idUsuarioLogado;
            this.usuarioException = usuarioException;
        }
    }
}
