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
        public string usuario { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public int statusUsuario { get; set; }
        public DateTime dataModificacao { get; set; }
        public int usuarioModificacao { get; set; }
        public int idUsuarioLogado { get; set; }
        public string usuarioException { get; set; }

        public Usuario() { }

        public Usuario(int idUsuario, string usuario, string nome, string email, string senha, int statusUsuario, DateTime dataModificacao, int usuarioModificacao, string usuarioException)
        {
            this.idUsuario = idUsuario;
            this.usuario = usuario;
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.statusUsuario = statusUsuario;
            this.dataModificacao = dataModificacao;
            this.usuarioModificacao = usuarioModificacao;
            this.idUsuarioLogado = idUsuarioLogado;
            this.usuarioException = usuarioException;
        }
    }
}
