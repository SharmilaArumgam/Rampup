using System.Collections.Generic;

namespace Mvc_CoreApplication.Models
{
	public class Home
	{
		public WebUser User { get; set; }

		public List<string> Countries { get; set; }
	}
}
