using shop.manoel.shared.Interfaces;
using shop.manoel.shared.Models;
using shop.manoel.shared.Models.Request;
using shop.manoel.shared.Models.Response;

namespace shop.manoel.service.Services
{
    public partial class ServiceOrder : IServiceOrder
    {
        private BoxCollection _boxCollection;

        public ServiceOrder()
        {
            _boxCollection = new BoxCollection();
            _boxCollection.Add(new Box() { caixa = "Caixa 1", comprimento = 30, largura = 40, altura = 80 });
            _boxCollection.Add(new Box() { caixa = "Caixa 2", comprimento = 80, largura = 50, altura = 40 });
            _boxCollection.Add(new Box() { caixa = "Caixa 3", comprimento = 50, largura = 80, altura = 60 });
        }

        public async Task<List<OrderResponse>> CalcOrderBoxAsync(OrderRequest request)
        {
            var orderResponseCollection = new List<OrderResponse>();
            foreach (var order in request.pedidos)
            {
                var response = ProductBoxCalc(order.produtos, _boxCollection);
                var boxeResponse = new BoxeResponse()
                {
                    caixa_id = response.caixa,
                    produtos = order.produtos.Select(x => x.produto_id).ToList(),
                    observacao = response.observacao

                };
                var boxeResponseCollection = new BoxeResponseCollection();
                boxeResponseCollection.Add(boxeResponse);

                orderResponseCollection.Add(new OrderResponse()
                {
                    pedido_id = order.pedido_id,
                    caixas = boxeResponseCollection
                });
            }

            return orderResponseCollection;
        }





    }
}
