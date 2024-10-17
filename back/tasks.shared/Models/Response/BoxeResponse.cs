using Newtonsoft.Json;

namespace shop.manoel.shared.Models.Response
{
    public class BoxeResponse
    {
        [JsonProperty("caixa_id")]
        public string caixa_id { get; set; }
        [JsonProperty("produtos")]
        public List<string> produtos { get; set; }
        [JsonProperty("observacao")]
        public string observacao { get; set; }

        public BoxeResponse()
        {
            produtos = new List<string>();
        }
    }

    public class BoxeResponseCollection : List<BoxeResponse> { }
}
