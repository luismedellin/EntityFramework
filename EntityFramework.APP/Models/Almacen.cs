using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.APP.Models
{
    public class Almacen
    {
        public int almacenId { get; set; }
        public string nombre { get; set; }
        public string title { get; set; }

        public FactGeo facGeo { get; set; }
    }
}
