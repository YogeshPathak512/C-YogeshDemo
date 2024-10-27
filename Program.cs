using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

internal class Program
{

	 class Employee
	{

		int EmpID;
		string EmpName;





		public Employee()
		{
			Console.WriteLine(EmpID);   //Default Constructor
			Console.WriteLine(EmpName);


		}


		public Employee(string EmpCode, String Name) //parametrized constructor
		{
			Console.WriteLine(EmpCode);
			Console.WriteLine(Name);

		}

	


		static void Main(string[] args)
		{
			Employee employee = new Employee("Emp1", "yogeshp");




		}
	}
}