using BaseInformations.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseInformations.Models
{
	public class Student:BaseEntity
	{
	
		public string Name { get; set; }
		public string Surname { get; set; }
		public Gender Gender { get; set; }
		public Faculty Faculty { get; set; }
		public DateOnly Birthday { get; set; }

		public Student(string name, string surname, Gender gender, Faculty faculty, DateOnly birthday):base()
		{
			Name = name;
			Surname = surname;
			Gender = gender;
			Faculty = faculty;
			Birthday = birthday;
		}
		public override string ToString()
		{
			return base.ToString() +
				$"Name: {Name}\n" +
				   $"Surname: {Surname}\n" +
				   $"Gender: {Gender}\n" +
				   $"Faculty: {Faculty}\n" +
				   $"Birthday: {Birthday}"; 
		}


	}
}
