using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoDeDependencia_DI_
{
    public class EnviarEmail
    {
        private string nome;
        public EnviarEmail()
        {
            nome = "programeVcTbm";
        }
        public bool Enviar(string email, string conteudo)
        {
            //Código de envio de email
            //Se der sucesso, retorna true.
            return true;
        }
    }
}
