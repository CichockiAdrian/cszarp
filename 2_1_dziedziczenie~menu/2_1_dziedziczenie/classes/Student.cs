using System;
namespace _2_1_dziedziczenie.classes
{
	public class Student : Person
	{
        public string StudentNumber { get; set; }

        public Student(string name, string surname, DateTime dateOfBirth, string studentNumber) : base(name, surname, dateOfBirth)
        {
            StudentNumber = studentNumber;
        }
    }
}

