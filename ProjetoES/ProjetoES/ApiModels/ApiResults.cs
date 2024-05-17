using System.Text.Json.Serialization;
using ProjetoES.Models;

namespace ProjetoES.ApiModels
{
    public class ApiResults
    {
        [JsonPropertyName("results")]
        public List<Movie> Results { get; set; }
    }
}
