using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseInformations.Models
{
	public class Faculty:BaseEntity
	{
		public string Name { get; set; }
		public Faculty(string name)
		{
			Name = name;
		}
		public override string ToString()
		{
			return base.ToString() + $"\nName: { Name}";
		}
	}
}
