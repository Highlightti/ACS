using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationClinicalSystem.br.com.acs.model
{
    class SystemExceptionsMessages
    {
        #region Singleton Pattern

        private static SystemExceptionsMessages instance;

        /// <summary>
        ///  Método responsável por criar uma instância da classe ConsumidorDAO (Singleton Pattern).
        /// </summary>
        public static SystemExceptionsMessages getInstance()
        {
            if (instance == null)
            {
                instance = new SystemExceptionsMessages();
            }
            return instance;
        }

        #endregion

        #region Login Messages

        public string TITLE_LOGIN_INVALIDO = "Dados incorretos";
        public string MESSAGE_LOGIN_INVALIDO = "\n\n" + "Usuário ou senha incorretos, por favor, insira-os corretamente.";
        public string MESSAGE_CAMPOS_VAZIOS = "\n\n" + "Por favor, insira os dados para poder entrar no sistema";

        #endregion

        #region Dados Usuário Messages

        public string TITLE_EMAIL_INVALIDO = "E-mail inválido";
        public string MESSAGE_EMAIL_INVALIDO = "\n" + "Este e-mail não pode ser utilizado, pois já está cadastrado em nosso sistema, por favor, informe outro e-mail válido";

        public string TITLE_DADOS_ATUALIZADOS = "Dados atualizados!";
        public string MESSAGE_DADOS_ATUALIZADOS = "Seus dados foram atualizados corretamente.";

        public string TITLE_ERRO_ATUALIZAR_DADOS = "Falha na conexão";
        public string MESSAGE_ERRO_ATUALIZAR_DADOS = "Houve uma falha ao tentar atualizar os seus dados, por favor, verifique sua conexão com a internet.";

        public string TITLE_DADOS_INVALIDOS = "Dados inválidos";
        public string MESSAGE_DADOS_INVALIDOS = "Por favor, preencha os campos corretamente para pode atualizar os seus dados.";

        public string TITLE_NOVA_SENHA_ERRO_REPETICAO = "Nova senha incorreta";
        public string MESSAGE_NOVA_SENHA_ERRO_REPETICAO = "A nova senha foi digitada no campo de repetição incorretamente, por favor, insira sua nova senha corretamente";

        public string TITLE_SENHA_ANTIGA_ERRADA = "Senha incorreta";
        public string MESSAGE_SENHA_ANTIGA_ERRADA = "Senha antiga informada está incorreta, por favor, insira sua senha corretamente.";

        public string TITLE_MESMOS_DADOS = "Dados iguais";
        public string MESSAGE_MESMOS_DADOS = "Caso deseje alterar seus dados, insira outros valores diferentes dos já cadastrados.";

        public string TITLE_SENHA_ATUALIZADA = "Senha atualizada!";
        public string MESSAGE_SENHA_ATUALIZADA = "Sua senha foi alterada com sucesso!";

        public string TITLE_ERRO_ATUALIZAR_SENHA = "Falha na conexão";
        public string MESSAGE_ERRO_ATUALIZAR_SENHA = "Houve uma falha ao tentar atualizar sua senha, por favor, verifique sua conexão com a internet.";

        #endregion

        #region Data Base Connection Messages

        public string ERRO_CONEXÃO_BANCO = "\n" + "Erro de comunicação com o Banco de Dados. \n Verifique sua conexão com a internet.";

        #endregion
    }
}
