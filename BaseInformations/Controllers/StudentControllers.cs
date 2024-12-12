using BaseInformations.Enum;
using BaseInformations.Models;
using BaseInformations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseInformations.Controllers
{
	public class StudentControllers
	{
		private StudentServices _studentServices;
		public StudentControllers()
		{
			_studentServices = new StudentServices();
		}
		public void Show_All_Student()
		{
			Student[] students = _studentServices.GetAllStudents();
			foreach (Student student in students)
			{
				Console.WriteLine($" Id:{student.Id}\n Name:{student.Name}\n " +
					$"Surname:{student.Surname}\n Gender:{student.Gender}\n " +
					$"Faculty:{student.Faculty.Name}\n Birthday:{student.Birthday}");
				Console.WriteLine("---------------------------------------------------------------------");
			}
		}
		public void Add_Student()
		{
			_studentServices.AddStudent();
		}
		public void Remove_Student()
		{
			_studentServices.RemoveStudent();
		}
		public void GetStudentByName()
		{
			Student searchedStudent = _studentServices.GetStudentByName();
			if (searchedStudent == null)
			{
				Console.WriteLine("Student not found!");
			}
			else
			{
				Console.WriteLine($" Id:{searchedStudent.Id}\n Name:{searchedStudent.Name}\n " +
					$"Surname:{searchedStudent.Surname}\n Gender:{searchedStudent.Gender}\n " +
					$"Faculty:{searchedStudent.Faculty.Name}\n Birthday:{searchedStudent.Birthday}");
			}
		}

		public void AddStudentToGroup()
		{

		}


	}
}
