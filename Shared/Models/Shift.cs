using System;
using vagtplanen.Shared.Models;

public class Shift {
    public int shift_id { get; set; }
    public DateTime start_time { get; set; }
    public DateTime end_time { get; set; }
    public bool taken { get; set; }
    public bool locked { get; set; }

    public Volunteer volunteer { get; set; }
    public TaskClass task { get; set; }

}
