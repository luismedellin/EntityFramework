using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.APP.Models
{
    public class Course
    {

        public Course()
        {
            this.students = new HashSet<Student>();
        }

        public int courseId { get; set; }
        public string name { get; set; }

        public virtual ICollection<Student> students { get; set; }
    }
}
