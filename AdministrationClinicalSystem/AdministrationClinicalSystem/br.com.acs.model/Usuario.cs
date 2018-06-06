using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationClinicalSystem.br.com.acs.model
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public int idUsuarioLogado { get; set; }
        public int statusUsuario { get; set; }
        public string usuario { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string tipoUsuarioLogado { get; set; }
        public string usuarioException { get; set; }
        public DateTime dataModificacao { get; set; }
        public NivelAcesso nivelAcesso { get; set; }

        public Usuario() { }

        public Usuario(int idUsuario, int idUsuarioLogado, int statusUsuario, string usuario, string nome, string email, string senha, string tipoUsuarioLogado, string usuarioException, DateTime dataModificacao, NivelAcesso nivelAcesso)
        {
            this.idUsuario = idUsuario;
            this.idUsuarioLogado = idUsuarioLogado;
            this.statusUsuario = statusUsuario;
            this.usuario = usuario;
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.tipoUsuarioLogado = tipoUsuarioLogado;
            this.usuarioException = usuarioException;
            this.dataModificacao = dataModificacao;
            this.nivelAcesso = nivelAcesso;
        }
    }
}
