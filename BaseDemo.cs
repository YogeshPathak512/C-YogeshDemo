using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_yogeshDemo
{
	internal class BaseDemo
	{
		//Base class
		public class Users
		{
			public string name = "Suresh Dasari";
			public string location = "Hyderabad";
			public int age = 32;
			public int id = 1;

			public Users(string a, string b)
			{
				Console.WriteLine( a);
				Console.WriteLine( b);
			}
			public virtual void GetInfo()
			{
				Console.WriteLine("Name: {0}", name);
				Console.WriteLine("Location: {0}", location);
			}
		}
		// Derived Class
		public class Details : Users
		{
			public Details(string x, string y) : base(x, y)
			{

			}
			public override void GetInfo()
			{
				base.GetInfo();
				Console.WriteLine("Age: {0}", base.age);
				Console.WriteLine(base.id);
              
			}
		}
		class Program
		{
			static void Main(string[] args)
			{
				Details d = new Details("AMAN","AKASH");
				d.GetInfo();
				Console.ReadLine();
		
			}
		}








	}
}
