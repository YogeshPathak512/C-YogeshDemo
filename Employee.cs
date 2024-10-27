using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_yogeshDemo
{
	internal class Employee:Person
	{

		public override int multiplyEmp(int Num1, int Num2)
		{
			return Num1 * Num2;
		}

		int id;
		String name;
		String address;

		public Employee(int id, String name, String address)
		{
			this.id = id;
			this.name = name;
			this.address = address;
		}

		public override string ToString()
		{
			return "Id : " + id + ", Name : " + name + ", Address ; " + address;		}
	}
}
