using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.APP.Models
{
    [ComplexType]
    public class GeoAlmacen
    {
        public string pais { get; set; }
        public string departamento { get; set; }
        public string ciudad { get; set; }
    }
}
