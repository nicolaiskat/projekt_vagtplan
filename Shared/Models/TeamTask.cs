using System;
namespace vagtplanen.Shared.Models
{
    public class TeamTask
    {
		public int teamtask_id { get; set; }
		public string description { get; set; }
		public bool locked { get; set; }
		public DateTime start_time { get; set; }
		public DateTime end_time { get; set; }
		public bool taken { get; set; }
		public int people_needed { get; set; }

		public Team team { get; set; }
	}
}
