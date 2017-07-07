using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.APP.Models
{
    public class Standard
    {
        public Standard()
        {

        }

        public int standardId { get; set; }
        public string name { get; set; }

        public ICollection<Student> students { get; set; }

    }
}
