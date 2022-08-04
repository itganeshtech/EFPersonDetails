using System;

namespace EFPersonDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            using var pc = new PersonContext();

            Console.WriteLine($"Databse Path: {pc.DbPath}");

            // Create
            Console.WriteLine("Inserting a new Person");
            pc.Add(new Person { SocialSecurityNumber= 111, FirstName="aaa", LastName="aaa" });
            pc.SaveChanges();



        }
    }
}
