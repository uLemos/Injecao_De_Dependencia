using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoDeDependencia_DI_
{
    public class POO
    {

        public static void objeto()
        {

            var _pessoas = new List<Pessoa>(); //Lista do Objeto
            _pessoas.Add(new Pessoa() { Nome = "Carol", Cpf = "3211544", Idade = 22 }); //Adicionando manualmente

            var _pessoa = new Pessoa(); // Objeto

            _pessoa.Nome = "Lemos";
            _pessoa.Cpf = "134343854";
            _pessoa.Idade = 21;

            _pessoas.Add(_pessoa); //Adicionando uma pessoa que já foi setada

            Console.WriteLine(_pessoas[1].Nome);
        }        
    }
}
