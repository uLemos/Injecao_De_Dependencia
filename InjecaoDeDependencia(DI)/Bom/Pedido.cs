using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoDeDependencia_DI_.Bom
{
    public class Pedido
    {
        private EnviarEmail _email;
        public Pedido(EnviarEmail email)
        {
            _email = email;
        }

        public void CriarPedido(PedidoModel pedidoModel)
        {
            _email.Enviar(pedidoModel.ClienteEmail, $"Seu pedido, {pedidoModel.Valor} foi gerado com sucesso!");
        }
    }
}
