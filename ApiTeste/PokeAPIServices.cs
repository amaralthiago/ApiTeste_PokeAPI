using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiTeste
{
    public class PokeAPIServices
    {
        public async Task<PokeAPI> Integracao(string value)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"https://pokeapi.co/api/v2/pokemon/{value}/");
            if (!response.IsSuccessStatusCode)
            {
                return new PokeAPI
                {
                    ValidaRetorno = true
                };
            }
            else
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                PokeAPI jsonObject = JsonConvert.DeserializeObject<PokeAPI>(jsonString);
                return jsonObject;
            }

        }
    }
}
