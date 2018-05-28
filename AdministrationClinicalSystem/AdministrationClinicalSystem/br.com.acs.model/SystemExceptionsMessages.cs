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


        public string TITLE_LOGIN_INVALIDO = "Dados incorretos";
        public string MESSAGE_LOGIN_INVALIDO = "\n\n" + "Usuário ou senha incorretos, por favor, insira-os corretamente.";
        public string MESSAGE_CAMPOS_VAZIOS = "\n\n" + "Por favor, insira os dados para poder entrar no sistema";

        public string ERRO_CONEXÃO_BANCO = "\n" + "Erro de comunicação com o Banco de Dados. \n Verifique sua conexão com a internet.";
    }
}
