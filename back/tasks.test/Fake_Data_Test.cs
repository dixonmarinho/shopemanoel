using shop.manoel.shared.Models;
using shop.manoel.shared.Models.Request;

namespace shop.manoel.test
{
    public static class Fake_Data_Test
    {

        private static ProductRequest GetProductReqest(string name, int altura, int largura, int comprimento)
        {
            return new ProductRequest()
            {
                produto_id = name,
                dimensoes = new ProductDimension() { altura = altura, largura = largura, comprimento = comprimento }
            };
        }

        public static OrderRequest OrderRequest_OK_1()
        {
            var productRequestCollection = new ProductRequestCollection();
            // Produtos do Pedido
            productRequestCollection.Add(GetProductReqest("PS5", 40, 10, 25));
            productRequestCollection.Add(GetProductReqest("Volante", 40, 30, 20));
            var orders = new OrderRequest();
            orders.pedidos.Add(new OrderRequestProduct()
            {
                pedido_id = 1,
                produtos = productRequestCollection
            });
            return orders;
        }

        public static OrderRequest OrderRequest_OK_2()
        {
            var productRequestCollection = new ProductRequestCollection();
            // Produtos do Pedido
            productRequestCollection.Add(GetProductReqest("Mouse Gamer", 5, 8, 12));
            productRequestCollection.Add(GetProductReqest("Teclado Mecânico", 4, 45, 15));
            var orders = new OrderRequest();
            orders.pedidos.Add(new OrderRequestProduct()
            {
                pedido_id = 1,
                produtos = productRequestCollection
            });
            return orders;
        }

        public static OrderRequest OrderRequest_OK_3()
        {
            var productRequestCollection = new ProductRequestCollection();
            // Produtos do Pedido
            productRequestCollection.Add(GetProductReqest("WebCan", 7, 10, 5));
            productRequestCollection.Add(GetProductReqest("Microfone", 25, 10, 10));
            productRequestCollection.Add(GetProductReqest("Monitor", 50, 60, 20));
            productRequestCollection.Add(GetProductReqest("Notebook", 2, 35, 25));
            var orders = new OrderRequest();
            orders.pedidos.Add(new OrderRequestProduct()
            {
                pedido_id = 1,
                produtos = productRequestCollection
            });
            return orders;
        }
    }
}
