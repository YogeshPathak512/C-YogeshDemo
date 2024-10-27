using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_yogeshDemo
{
	internal class DynamicDemo
	{
		static void Main(string[] args)
		{

			dynamic D = 300;
			Console.WriteLine("Value: {0}, Type: {1}", D, D.GetType());

			D = "Hey Welcome !";
			Console.WriteLine("Value: {0}, Type: {1}",D, D.GetType());

			D = false;
			Console.WriteLine("Value: {0}, Type: {1}", D,D.GetType());

			D = DateTime.Today;
			Console.WriteLine("Value: {0}, Type: {1}",D, D.GetType());


			dynamic show(dynamic a)
			{

				return a;

			}

			
				dynamic obj = new DynamicDemo();
				// obj.hello();

				dynamic s = obj.show(obj);
				Console.WriteLine(s.GetType());
			

		}
	}
}
