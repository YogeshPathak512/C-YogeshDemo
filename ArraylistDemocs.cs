using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_yogeshDemo
{
	internal class ArraylistDemocs
	{
		static void Main(string[] args)
		{

			ArrayList Al = new ArrayList();

			Al.Add("YogeshP");
			Al.Add(1);
			Al.Add(2);
			Al.Add(5);
			Al.Add(4);
			Al.Add(7);

			Al.Remove(1);
			Al.Reverse();
			foreach (var item in Al)
			{
				Console.WriteLine(item);
			}




			IEnumerator enumerator = Al.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Console.WriteLine(enumerator.Current);
			}

		}
}
}
