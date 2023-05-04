using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoDeDependencia_DI_.Ruim
{
    public class Pedido
    {
        public void CriarPedido(PedidoModel pedidoModel)
        {
            //Validações
            //Gravar

            var email = new EnviarEmail("w", "end");
            email.Enviar(pedidoModel.ClienteEmail, $"Seu pedido {pedidoModel.Numero} foi gerado com sucesso!")
        }
    }
}
