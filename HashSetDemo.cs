using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_yogeshDemo
{
	internal class HashSetDemo
	{
        static void Main(string[] args)
        {

			HashSet<string> Hs = new HashSet<string>();

			Hs.Add("A");
			Hs.Add("B");
			Hs.Add("C");

			Hs.Remove("A");


			foreach (string s in Hs)
			{
                Console.WriteLine(s);
			}
		}

	}
}
