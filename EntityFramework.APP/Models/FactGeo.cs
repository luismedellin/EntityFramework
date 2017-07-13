using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.APP.Models
{
    public class FactGeo
    {
        public int FactGeoId { get; set; }
        public Pais pais { get; set; }
        public Departamento departamento { get; set; }
        public Ciudad ciudad { get; set; }


        public FactGeo()
        {
            pais = new Pais();
            departamento = new Departamento();
            ciudad = new Ciudad();
        }

    }
}
