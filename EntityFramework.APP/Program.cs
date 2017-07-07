using EntityFramework.APP.Models;
using System;

namespace EntityFramework.APP
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                Student student = new Student() { name = "Luis" };

                ctx.students.Add(student);
                ctx.SaveChanges();

            }


            Console.ReadLine();
        }
    }
}
