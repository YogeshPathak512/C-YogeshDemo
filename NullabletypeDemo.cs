using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_yogeshDemo
{
	internal class NullabletypeDemo
	{
		static void Main(string[] args)

		{


		
			
			int? a = null;

			
			int? b = 2345;

		
			Console.WriteLine(a);

			// gives 2345 as output
			Console.WriteLine(b);




			Console.WriteLine(a.HasValue);

			// b is nullable type
			// and contains a value
			Nullable<int> c = 7;

			// check the value of object
			Console.WriteLine(c.HasValue);
		}
	}
}
