using Newtonsoft.Json;

namespace shop.manoel.shared.Models.Request
{
    public class OrderRequestProduct
    {
        [JsonProperty("pedido_id")]
        public int pedido_id { get; set; }
        [JsonProperty("produtos")]
        public ProductRequestCollection produtos { get; set; }

        public OrderRequestProduct()
        {
            produtos = new ProductRequestCollection();
        }
    }

    public class OrderRequest
    {
        [JsonProperty("pedidos")]
        public List<OrderRequestProduct> pedidos { get; set; }

        public OrderRequest()
        {
            pedidos = new List<OrderRequestProduct>();
        }
    }



}
