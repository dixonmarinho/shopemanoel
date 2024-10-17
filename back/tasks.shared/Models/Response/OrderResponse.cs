using Newtonsoft.Json;

namespace shop.manoel.shared.Models.Response
{
    public class OrderResponse
    {
        [JsonProperty("pedido_id")]
        public int pedido_id { get; set; }

        [JsonProperty("caixas")]
        public BoxeResponseCollection caixas { get; set; }

        public OrderResponse()
        {
            caixas = new BoxeResponseCollection();
        }
    }
}
