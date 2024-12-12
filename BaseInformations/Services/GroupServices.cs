using BaseInformations.Enum;
using BaseInformations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseInformations.Services
{
	public class GroupServices
	{
		private List<Group> _groups;
		public List<Teacher> Teachers;
		public List<Student> Students;
		public GroupServices()
		{
			_groups = new List<Group>
			{
				new Group("P140",Teachers,Students),
				new Group("P145",Teachers,Students)
			};
		}
		public Group[] GetAllGroups()
		{
			return _groups.ToArray();
		}
		public void ShowAllGroup()
		{
			foreach (Group group in _groups)
			{
				Console.WriteLine($"Group Id:{group.Id}\n Group Name:{group.GroupName}");
				Console.WriteLine("----------------------------------------------------");
			}
		}
		public Group GetGroupByName()
		{
			Group[]groups = GetAllGroups();
			Console.WriteLine("Enter group name:");
			string groupName=Console.ReadLine();
			Group searchedGroup=groups.FirstOrDefault(group => group.GroupName.ToLower().Trim() ==
			groupName.ToLower().Trim());
			return searchedGroup;
		}
	}
}
