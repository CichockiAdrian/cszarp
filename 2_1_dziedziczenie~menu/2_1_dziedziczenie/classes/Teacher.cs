using System;
namespace _2_1_dziedziczenie.classes
{
	public class Teacher : Person
	{
        public List<string> Subjects { get; set; }

        public Teacher(string name, string surname, DateTime dateOfBirth, List<string> subjects) : base(name, surname, dateOfBirth)
        {
            Subjects = subjects;
        }
    }
}

