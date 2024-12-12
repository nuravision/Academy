using BaseInformations.Controllers;
using BaseInformations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyTask.Application
{
	public class Menu
	{
		private StudentControllers studentControllers;
		private TeacherControllers teacherControllers;
		private GroupControllers groupControllers;
		private FacultyControllers facultyControllers;
		public Menu()
		{
			studentControllers = new StudentControllers();
			teacherControllers = new TeacherControllers();
			groupControllers = new GroupControllers();
			facultyControllers = new FacultyControllers();
		}
		public void ShowAllApp()
		{
			bool check = true;
			while (check)
			{
				Console.WriteLine("Choices:");
				Console.WriteLine("0.Exit");
				Console.WriteLine("1.Show All Students");
				Console.WriteLine("2.Show All Teachers");
				Console.WriteLine("3.Show All Groups");
				Console.WriteLine("4.Show All Faculties");
				Console.WriteLine("5.Get Student by Name");
				Console.WriteLine("6.Get Teacher by Name");
				Console.WriteLine("7.Get Group by Name");
				Console.WriteLine("8.Get Faculty by Name");
				Console.WriteLine("9.Add Student");
				Console.WriteLine("10.Remove Student By Name");
				Console.Write("Please enter your choice:");
				string inputChoice = Console.ReadLine();

				if (inputChoice == "0")
				{
					check = false;
				}
				else if (inputChoice == "1")
				{
					studentControllers.Show_All_Student();
				}
				else if (inputChoice == "2")
				{
					teacherControllers.ShowAllTeachers();
				}
				else if (inputChoice == "3")
				{
					groupControllers.Show_All_Group();
				}
				else if (inputChoice == "4")
				{
					facultyControllers.Show_All_Faculties();
				}
				else if (inputChoice == "5")
				{
					studentControllers.GetStudentByName();
				}
				else if (inputChoice == "6")
				{
					teacherControllers.GetTeacherByName();
				}
				else if (inputChoice == "7")
				{
					groupControllers.Search_Group_By_Name();
				}
				else if (inputChoice == "8")
				{
					facultyControllers.Search_Faculty_By_Name();
				}
				else if (inputChoice == "9")
				{
					studentControllers.Add_Student();
				}
				else if (inputChoice == "10")
				{
					studentControllers.Remove_Student();
				}
			}
		}
	}
}
