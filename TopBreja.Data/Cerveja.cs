﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopBreja.Data
{
    public class Cerveja
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string teor_alcoolico { get; set; }
        public string pais { get; set; }

        public int categoria_id { get; set; }
        public int local_id { get; set; }


        // Se conseguiram enxergar isso é porque resolvi o erro do cadeado azul do capiroto ;)
    }
}
