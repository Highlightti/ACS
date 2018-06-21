using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministrationClinicalSystem.br.com.acs.dao;
using AdministrationClinicalSystem.br.com.acs.model;

namespace AdministrationClinicalSystem.br.com.acs.controller
{
    class PessoaController
    {
        private static PessoaController instance;

        #region Singleton Pattern Controller

        /// <summary>
        ///  Método responsável por criar uma instância da classe PessoaController (Singleton Pattern).
        /// </summary>
        public static PessoaController getInstance()
        {
            if (instance == null)
            {
                instance = new PessoaController();
            }
            return instance;
        }

        #endregion

        public Pessoa CadastrarPessoa(Pessoa pessoa)
        {
            PessoaDAO pessoaDAO = PessoaDAO.getInstance();
            pessoa = pessoaDAO.CadastrarPessoa(pessoa);

            return pessoa;
        }

        
    }
}
