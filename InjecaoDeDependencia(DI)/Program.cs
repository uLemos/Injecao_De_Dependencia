using System;
using System.Collections.Generic;

namespace InjecaoDeDependencia_DI_
{
    public class Program
    {
        static void Main(string[] args)
        {
            //POO.objeto();

            var pedido = new PedidoModel()
            {
                Numero = 7,
                ClienteEmail = "dawdad@gmail.com",
                Itens = new List<string>() { "Item01", "Itemo02" },
                Valor = 1000
            };

            //Sem Injeção
            new Ruim.Pedido().CriarPedido(pedido);

            var email = new EnviarEmail();

            new Bom.Pedido(email).CriarPedido(pedido);

            Console.WriteLine("Hello World!");
        }
    }
}
