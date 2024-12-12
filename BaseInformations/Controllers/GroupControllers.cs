using BaseInformations.Models;
using BaseInformations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseInformations.Controllers
{
	public class GroupControllers
	{
		private GroupServices _groupServices ;
		private StudentServices _studentServices ;
		public GroupControllers()
		{
			_groupServices = new GroupServices();
			_studentServices = new StudentServices();
		}
		public void Show_All_Group()
		{
			_groupServices.ShowAllGroup();
		}
		public void Search_Group_By_Name()
		{
			Group group = _groupServices.GetGroupByName();
			if (group == null)
			{
				Console.WriteLine("Group not found!");
			}
			else
			{
				Console.WriteLine($"Group Id:{group.Id}\nGroup Name:{group.GroupName}");
			}
		}
	}
}
