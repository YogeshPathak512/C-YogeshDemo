using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_yogeshDemo
{
	internal class VarDemo
	{
		public int add(int x, int z)
		{ return x + z; }
		static void Main(string[] args)
		{

			var employee = "yyy";
			var i = 10;
			i = 12;

			Console.WriteLine(i.GetType());

			var s = " yogesh";
			Console.WriteLine(s.GetType());
			Console.WriteLine(s);

			var e = new int[] { 28, 9, 9, 58};
			Console.WriteLine(e.GetType());
			VarDemo obj = new VarDemo();
			var values = obj.show();

			foreach (var v in values)
			{
				Console.WriteLine(v);
			}
			var dd = obj.add(12, 23);
			Console.WriteLine(dd);
		}
		public List<int> show()
		{


			return new List<int> { 28, 9, 9, 58};
		}
	}
}
