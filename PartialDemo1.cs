using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_yogeshDemo
{
	internal partial class PartialDemo1
	{
	   
			static void Main(string[] args)
			{

				PartialDemo P = new PartialDemo
				{
					FirstName = "Pranaya",
					LastName = "Rout",
					Salary = 100000,
					Gender = "Male"
				};
				P.DisplayFullName();
				P.DisplayEmployeeDetails();
				Console.ReadKey();
			}







	}
}

