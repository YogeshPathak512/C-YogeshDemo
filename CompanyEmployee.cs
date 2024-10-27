using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_yogeshDemo
{
	internal interface IEmployee
	{
		void EmpShowName();

		void EmployeeData();
	}
	internal interface IEmployee1
	{
		void EmpShowName();
		void EmpShowDetails();

	}
	internal class CompanyEmployee : IEmployee1, IEmployee
	{
		void IEmployee1.EmpShowName()
		{
            Console.WriteLine("this method of IEmploye1");
		}

		void IEmployee.EmpShowName()
		{
            Console.WriteLine("this method of Iemployee");
		}
		void IEmployee.EmployeeData()
		{
			Console.WriteLine("this method of Iemployee");
		}

		void IEmployee1.EmpShowDetails()
		{
			Console.WriteLine("this method of Iemployee1" 
				);
		}

		
	}
}
