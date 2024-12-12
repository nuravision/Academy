using BaseInformations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseInformations.Services
{
	public class FacultyServices
	{
		private List<Faculty> faculties;
		public FacultyServices()
		{
			faculties = new List<Faculty>
			{
				new Faculty("Mathmatics"),
				new Faculty("Biology"),
				new Faculty("History"),
				new Faculty("IT")
			};
		}
		public Faculty[] GetAllFaculties()
		{
			return faculties.ToArray();
		}
		public void ShowAllFaculties()
		{
			Faculty[]faculties=GetAllFaculties();
			foreach (Faculty faculty in faculties)
			{
				Console.WriteLine($"Faculty Id:{faculty.Id}\nFaculty Name:{faculty.Name}");
				Console.WriteLine("--------------------------------------------------");
			}
		}
		public Faculty GetFacultyByName()
		{
			Faculty[] faculties = GetAllFaculties();
			Console.WriteLine("Enter facultie name:");
			string facultyName = Console.ReadLine();
			Faculty searchedFaculty = faculties.FirstOrDefault(faculty => faculty.Name.ToLower().Trim() ==
			facultyName.ToLower().Trim());
			return searchedFaculty;
		}
	}
}
