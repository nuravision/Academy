using BaseInformations.Models;
using BaseInformations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseInformations.Controllers
{
	public class FacultyControllers
	{
		private FacultyServices _facultyServices;
		public FacultyControllers()
		{
			_facultyServices = new FacultyServices();
		}
		public void Show_All_Faculties()
		{
			_facultyServices.ShowAllFaculties();
		}
		public void Search_Faculty_By_Name()
		{
			Faculty faculty = _facultyServices.GetFacultyByName();
			if (faculty == null)
			{
				Console.WriteLine("Faculty not found!");
			}
			else
			{
				Console.WriteLine($"Group Id:{faculty.Id}\nGroup Name:{faculty.Name}");
			}
		}
	}
}
