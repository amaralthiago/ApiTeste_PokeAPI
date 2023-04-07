using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTeste
{
    public class PokeAPI
    {
        public int id { get; set; }
        public string name { get; set; }
        public string base_experience { get; set; }
        public double height { get; set; }
        public int order { get; set; }
        public double weight { get; set; }

        public bool ValidaRetorno = false;
    }
}
