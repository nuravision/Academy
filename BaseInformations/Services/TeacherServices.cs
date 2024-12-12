using BaseInformations.Enum;
using BaseInformations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseInformations.Services
{
	public class TeacherServices
	{
		private List<Teacher> _teachers;
		public TeacherServices()
		{
			_teachers = new List<Teacher>
			{
				new Teacher("Ismayil","Seyidmemmedli",Gender.Male,
				"Teacher and programmer",new DateOnly(1997,6,4)),
				new Teacher("Lala","Muradova",Gender.Female,
				"Teacher and programmer",new DateOnly(1998,1,1)),
				new Teacher("Cavid","Atamoglanov",Gender.Male,
				"Teacher and programmer",new DateOnly(1998,7,10)),
			};
		}
		public Teacher[] GetAllTeachers()
		{
			return _teachers.ToArray();
		}

		public Teacher GetTeacherByName()
		{
			Teacher[]teachers=GetAllTeachers();
			Console.WriteLine("Enter searched teacher name:");
			string searchedTeacherName=Console.ReadLine();
			Teacher searchedTeacher = teachers.FirstOrDefault(teacher =>
			teacher.Name.ToLower().Trim() == searchedTeacherName.ToLower().Trim());
			return searchedTeacher;
		}
	}
}
