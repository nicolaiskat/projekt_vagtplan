using System;
using System.Collections.Generic;

namespace vagtplanen.Shared.Models
{
    public class Team
    {
        public int team_id { get; set; }
        public string name { get; set; }
		public string contact_name { get; set; }
		public string mobile { get; set; }
		public string email { get; set; }
		public string password { get; set; }
		public int access { get; set; }
		public int hours { get; set; }

		public List<TeamTask> teamtasks { get; set; }
		public List<Skill> skills { get; set; }

	}
}
