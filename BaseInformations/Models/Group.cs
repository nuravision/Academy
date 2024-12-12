using BaseInformations.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseInformations.Models
{
	public class Group:BaseEntity
	{
		public string GroupName { get; set; }
		public List<Teacher> Teachers { get; set; }
		public List<Student> Students { get; set; }
		public Group(string groupName, List<Teacher>teachers, List<Student> students)
		{
			GroupName = groupName;
			Teachers = teachers;
			Students = students;
		}
	}
}
