using Newtonsoft.Json;

namespace shop.manoel.shared.Models
{
    public class ProductDimension
    {
        /// <summary>
        /// Altura do produto
        /// </summary>
        [JsonProperty("altura")]
        public int altura { get; set; }
        /// <summary>
        /// Largura do produto
        /// </summary>
        [JsonProperty("largura")]
        public int largura { get; set; }
        /// <summary>
        /// Comprimento do produto
        /// </summary>
        [JsonProperty("comprimento")]
        public int comprimento { get; set; }
    }
}
