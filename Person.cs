using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_yogeshDemo
{
	internal abstract class Person
	{
		// An abstract method which 
		// overridden in the employee  class
		public abstract int multiplyEmp(int Num1, int Num2);
		public void method1()
		{


            Console.WriteLine("method 1");
		
		}
		public void method2()
		{

			Console.WriteLine("method 2");


		}
		public void method3()
		{

			Console.WriteLine("method 3 ");


		}
		public int AddTwoNumbers(int Num1, int Num2)
		{
			return Num1 + Num2;
		}

		

	}
}
