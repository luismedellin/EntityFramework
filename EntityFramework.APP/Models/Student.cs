using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.APP.Models
{
    public class Student
    {
        public Student()
        {

        }

        public int studentId { get; set; }
        public string name { get; set; }
        public DateTime? dateOfBirth { get; set; }
        public byte[] photo { get; set; }
        public decimal height { get; set; }
        public float weight { get; set; }

        public Standard standard { get; set; }

    }
}
