using Newtonsoft.Json;

namespace shop.manoel.shared.Models
{
    public class Box : ProductDimension
    {
        [JsonProperty("caixa")]
        public string caixa { get; set; }
        [JsonProperty("observacao")]
        public string observacao { get; set; }
    }

    public class BoxCollection : List<Box> { }
}
