using BaseInformations.Models;
using BaseInformations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseInformations.Controllers
{
	public class TeacherControllers
	{
		private TeacherServices _teacherServices;
		public TeacherControllers()
		{
			_teacherServices = new TeacherServices();
		}
		public void ShowAllTeachers()
		{
			Teacher[]teachers =_teacherServices.GetAllTeachers() ;
			foreach (Teacher teacher in teachers)
			{
				Console.WriteLine($" Id:{teacher.Id}\n Name:{teacher.Name}\n " +
					$"Surname:{teacher.Surname}\n Gender:{teacher.Gender}\n " +
					$"Faculty:{teacher.Speciality}\n Birthday:{teacher.Birthday}");
				Console.WriteLine("---------------------------------------------------------------------");
			}
		}
		public void GetTeacherByName()
		{
			Teacher searchedTeacher=_teacherServices.GetTeacherByName() ;
			if (searchedTeacher==null)
			{
				Console.WriteLine("Teacher not found!");
			}
			else
			{
				Console.WriteLine($" Id:{searchedTeacher.Id}\n Name:{searchedTeacher.Name}\n " +
					$"Surname:{searchedTeacher.Surname}\n Gender:{searchedTeacher.Gender}\n " +
					$"Faculty:{searchedTeacher.Speciality}\n Birthday:{searchedTeacher.Birthday}");
			}
		}
	}
}
