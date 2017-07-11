using EntityFramework.APP.Models;
using System;

namespace EntityFramework.APP
{
    class Program
    {
        static void Main(string[] args)
        {
            //insertStudent();


            using (var ctx = new SchoolContext())
            {
                Student student = new Student() { name = "Mary" };
                StudentAddress address = new StudentAddress() { Address1 = "calle #" };
                //asocio la dirección del estudiante
                student.address = address;

                //guardo la información del estudiante
                ctx.students.Add(student);
                ctx.SaveChanges();

                //borro en cascada la información del estudiante.
                ctx.students.Remove(student);
                ctx.SaveChanges();
            }


            Console.ReadLine();
        }

        private static void insertStudent()
        {
            using (var ctx = new SchoolContext())
            {
                Student student = new Student() { name = "Luis" };

                ctx.students.Add(student);
                ctx.SaveChanges();
            }
        }
    }
}
