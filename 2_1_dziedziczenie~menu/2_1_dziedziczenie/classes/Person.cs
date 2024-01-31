using System;
using System.Net;


namespace _2_1_dziedziczenie.classes
{
	public class Person
	{
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public byte Age
        {
            get
            {
                TimeSpan difference = DateTime.Now - DateOfBirth;
                return (byte)(difference.Days / 365.25);
            }
        }

        public Address Address { get; set; }

        public Person(string name, string surname, DateTime dateOfBirth, Address address)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Address = address;
        }

        public Person(string name, string surname, DateTime dateOfBirth)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
        }

        public string GetFullName()
        {
            return $"Imię i nazwisko: {Name} {Surname}";
        }


    }
}

