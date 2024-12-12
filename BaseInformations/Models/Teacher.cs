using BaseInformations.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseInformations.Models
{
	public class Teacher:BaseEntity
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public Gender Gender { get; set; }
		public string Speciality { get; set; }
		public DateOnly Birthday { get; set; }

		public Teacher(string name, string surname, Gender gender, string speciality, DateOnly birthday):base()
		{
			Name = name;
			Surname = surname;
			Gender = gender;
			Speciality = speciality;
			Birthday = birthday;
		}
		public override string ToString()
		{
			return base.ToString() +
				$"Name: {Name}\n" +
				   $"Surname: {Surname}\n" +
				   $"Gender: {Gender}\n" +
					$"Speciality: {Speciality}\n" +
				   $"Birthday: {Birthday}";
		}

	}
}
