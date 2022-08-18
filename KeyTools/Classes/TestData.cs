using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyTools.Classes
{

	public class TestData
	{
		public string _id { get; set; }
		public string dlc { get; set; }
		public int version { get; set; }
		public string label { get; set; }
		public string type { get; set; }
		public List<string> tags { get; set; }
		public string sound { get; set; }
		public int repetitions { get; set; }
		public string quest { get; set; }
		public string right { get; set; }
		public List<string> wrong { get; set; }
		public List<string> idle { get; set; }
		public List<string> images { get; set; }
		public List<int> correctImages { get; set; }
		public List<int> placedImages { get; set; }
		public int order { get; set; }
		public string status { get; set; }
		public string comment { get; set; }
		public string require { get; set; }
	}
}