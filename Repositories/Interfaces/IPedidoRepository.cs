using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto.Models;

namespace Projeto.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        void CriarPedido (Pedido pedido);
    }
}