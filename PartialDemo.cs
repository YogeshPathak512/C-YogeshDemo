﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_yogeshDemo
{
	internal partial class PartialDemo
	{

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Gender { get; set; }
		public double Salary { get; set; }

		public void DisplayFullName()
		{
			Console.WriteLine($"Full Name is : {FirstName} {LastName}");
		}
		public void DisplayEmployeeDetails()
		{
			Console.WriteLine("Employee Details : ");
			Console.WriteLine($"First Name : {FirstName}");
			Console.WriteLine($"Last Name : {LastName}");
			Console.WriteLine($"Gender : {Gender}");
			Console.WriteLine($"Salary : {Salary}");
		}

	}


	
}
