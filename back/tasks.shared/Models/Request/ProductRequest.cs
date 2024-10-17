using Newtonsoft.Json;

namespace shop.manoel.shared.Models.Request
{
    public class ProductRequest
    {
        [JsonProperty("produto_id")]
        public string produto_id { get; set; }
        [JsonProperty("dimensoes")]
        public ProductDimension dimensoes { get; set; }

        public ProductRequest()
        {
            dimensoes = new ProductDimension();
        }
    }
    public class ProductRequestCollection : List<ProductRequest> { }

}
