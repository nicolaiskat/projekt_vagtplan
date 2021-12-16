using System;
using System.Collections.Generic;
using vagtplanen.Shared.Models;

public class Volunteer : User  {
	public int volunteer_id { get; set; }
    public double hours {
        get
        {
            double sum = 0;
            if (shifts != null)
            {
                foreach (Shift shift in shifts)
                {
                    if (shift != null)
                    {
                        var hours = (shift.end_time - shift.start_time).TotalHours;
                        sum += hours;
                    }

                }
            }
            return sum;
        }
    }

    public double points
    {
        get
        {
            double sum = -6;
            if (shifts != null)
            {
                foreach (Shift shift in shifts)
                {
                    if (shift != null)
                    {
                        if (DateTime.Compare(shift.end_time, DateTime.Now) == -1)
                        {
                            var hours = (shift.end_time - shift.start_time).TotalHours;
                            sum += hours;
                        }
                    }
                }
            }
            if (coupons != null)
            {
                foreach (Coupon coupon in coupons)
                {
                    if (coupon != null )
                    {
                        sum -= coupon.price;
                    }
                }
            }
            if (sum < 0)
                return 0;
            return sum;
        }
    }

    public List<Shift> shifts { get; set; }
	public List<Coupon> coupons { get; set; }
    public List<Skill> skills { get; set; }
}
