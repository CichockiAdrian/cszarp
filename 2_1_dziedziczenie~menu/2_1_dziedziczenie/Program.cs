using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using _2_1_dziedziczenie.classes;

namespace lekcja_1
{
    internal class Program
    { 

        static void Main(string[] args)
        {
            Person p1 = new Person("Adam", "Nowak", new DateTime(1999, 1, 2), new Address("Poznan", "Polna", "1c/2", "12-345"));
            Student s1 = new Student("Adam", "Nowak", new DateTime(1999, 1, 2),"12345");
            Teacher t1 = new Teacher("Adam", "Nowak", new DateTime(1999, 1, 2), new List<string> { "matematyka", "informatyka"});


            Console.WriteLine($"Imię i nazwisko: {p1.Name} {p1.Surname}, data urodzenia: {p1.DateOfBirth.ToShortDateString()}, adres: {p1.Address.City}, {p1.Address.Street}, {p1.Address.HouseNumber}\n");
            Console.WriteLine($"Imię i nazwisko: {s1.Name} {s1.Surname}, data urodzenia: {s1.DateOfBirth.ToShortDateString()}, numer indeksu: {s1.StudentNumber}\n");
            Console.WriteLine($"Imię i nazwisko: {t1.Name} {t1.Surname}, data urodzenia: {t1.DateOfBirth.ToShortDateString()}, przedmioty: {string.Join(", ",t1.Subjects)}\n");

            Console.ReadKey();
        }
        
    }
}