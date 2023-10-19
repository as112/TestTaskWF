using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask_WF.Models
{
	public class Steps
	{
		public int Id { get; set; }
		public int ModeId { get; set; }
		public int Timer { get; set; }
		public string Destination { get; set; }
		public int Speed { get; set; }
		public string Type { get; set; }
		public int Volume { get; set; }
	}
}
