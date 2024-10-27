using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace C_yogeshDemo
{
	internal class EmployeeList
	{
		static void Main(string[] args)
		{
			List<Employee> empList = new List<Employee>();
			Employee emp1 = new Employee(1, "Kausher", "USA");
			Employee emp2 = new Employee(2, "Yogesh", "Japan");
			Employee emp3 = new Employee(3, "Deepak", "Germany");
			Employee emp4 = new Employee(4, "Mahesh", "canada");



			empList.Add(emp1);
			empList.Add(emp2);
			empList.Add(emp3);
			empList.Add(emp4);

			foreach (var item in empList)
			{
				
				Console.WriteLine(item);
			}
		}

	
	

		

	}
}