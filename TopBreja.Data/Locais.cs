using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopBreja.Data
{
    public class Locais
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }

        public int cidade_id { get; set; }

    }
}
