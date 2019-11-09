using System.Collections.Generic;
using Newtonsoft.Json;

namespace Domain.Models
{
    public class Imovel
    {
        //id, identificação, numero, bairro, cidade, estado
            public int id { get; set; }
            public string identificacao { get; set; }
            public int numero { get; set; }
            public string bairro { get; set; }
            public string cidade {get; set; }
            public string estado { get; set; }

            [JsonIgnore]
            public List<Conta> conta { get; set; }
    }
}