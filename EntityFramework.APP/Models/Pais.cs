using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.APP.Models
{
    public class Pais
    {
        public int paisId { get; set; }
        public string pais { get; set; }
        public List<Departamento> departamentos { get; set; }
    }
}
