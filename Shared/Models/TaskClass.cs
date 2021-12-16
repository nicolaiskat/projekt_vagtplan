using System;
using System.Collections.Generic;

namespace vagtplanen.Shared.Models
{
    public class TaskClass
    {
		public int task_id { get; set; }
		public string description { get; set; }
		public int number_of_shifts { get; set; }
		public bool locked { get; set; }

		public List<Shift> shifts { get; set; }
	}
}
