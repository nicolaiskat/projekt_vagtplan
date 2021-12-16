using System;
using System.ComponentModel.DataAnnotations;

public class User {

	public string first_name { get; set; }
	public string last_name { get; set; }
	public string mobile { get; set; }
	public string password { get; set; }
	public int access { get; set; }
	public string email { get; set; }
    public string address { get; set; }
	public string cpr { get; set; }
	public string gender { get; set; }
}
