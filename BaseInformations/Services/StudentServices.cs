using BaseInformations.Enum;
using BaseInformations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseInformations.Services
{
	public class StudentServices
	{
		private List<Student> _students;
		public StudentServices()
		{
			_students = new List<Student>
			{
				new Student("Nurana", "Ismayilzada", Gender.Female,
					new Faculty("Kibernetika"), new DateOnly(2002, 10, 19)),
				new Student("Alisa", "Ismayilzada", Gender.Female,
					new Faculty("Riyaziyyat"), new DateOnly(2002, 10, 19)),
				new Student("Melisa", "Ismayilzada", Gender.Female,
					new Faculty("Informatika"), new DateOnly(2002, 10, 19))
			};
		}
		public Student[] GetAllStudents()
		{
			return _students.ToArray();
		}
		public void AddStudent()
		{
			Student[] students =GetAllStudents();
			string newName;
			Console.WriteLine("Enter new student name:");
			newName = Console.ReadLine();
			string newSurname;
			Console.WriteLine("Enter new student surname:");
			newSurname = Console.ReadLine();
			Gender newGender = new Gender();
			string newgender;
			Console.WriteLine("Enter new student gender (1-Male 2-Female):");
			genderFormat: newgender = Console.ReadLine();
			if (newgender.ToLower() == Gender.Female.ToString().ToLower())
			{
				newGender = Gender.Female;
			}
			else if (newgender.ToLower() == Gender.Male.ToString().ToLower())
			{
				newGender = Gender.Male;
			}
			else
			{
				Console.WriteLine("Wrong format!");
				goto genderFormat;
			}
			Console.WriteLine("Enter faculty name:");
			string facultyName = Console.ReadLine();
			Faculty newFaculty = new Faculty(facultyName);
			Console.WriteLine("Enter your birthday (yyyy-MM-dd):");
			birthday: string newBirthday = Console.ReadLine();
			DateOnly newBirthDay;
			if (DateOnly.TryParse(newBirthday, out newBirthDay)) ;
			else
			{
				Console.WriteLine("Invalid date format! Please use yyyy-MM-dd.");
				goto birthday;
			}
			Student newStudent = new Student(newName, newSurname, newGender, newFaculty, newBirthDay);
			_students.Add(newStudent);
		}
		public Student RemoveStudent()
		{
			Console.WriteLine("Enter the name of the student to remove:");
			string deletedStudentName = Console.ReadLine();
			List<Student> students = GetAllStudents().ToList();
			Student studentToRemove=students.FirstOrDefault(student=>
			student.Name.ToLower().Trim()==deletedStudentName.ToLower().Trim());
			if (studentToRemove != null)
			{
				students.Remove(studentToRemove);
				Console.WriteLine($"Student {studentToRemove.Name} successfully removed.");
				_students.Remove(studentToRemove);
				return studentToRemove;
			}
			Console.WriteLine("Student not found.");
			return null;
		}
		public Student GetStudentByName()
		{
			Student[] students = GetAllStudents();
			Console.WriteLine("Enter searched student name:");
			string studentName = Console.ReadLine();
			Student searchedStudent=students.FirstOrDefault(student => student.Name.ToLower().Trim() ==
			studentName.ToLower().Trim());
			if (searchedStudent != null)
			{
				return searchedStudent;
			}
			return null;
		}
	}
}
