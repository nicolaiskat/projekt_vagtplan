using System;
using System.Collections.Generic;

namespace vagtplanen.Shared.Models
{
    public class Skill
    {
        public int skill_id { get; set; }
        public string name { get; set; }

        public List<Team> teams { get; set; }
        public List<Volunteer> volunteers { get; set; }
    }
}
