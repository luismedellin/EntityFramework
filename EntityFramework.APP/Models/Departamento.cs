using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.APP.Models
{
    public class Departamento
    {
        public int departamentoId { get; set; }
        public string deparmento { get; set; }
        public List<Ciudad> ciudades { get; set; }
    }
}
