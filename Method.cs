using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_yogeshDemo
{
	internal class MethodOverloading 
	{

		public void  sum(int x, int y)
		{

            Console.WriteLine(x+y);
		
		
		
		}

		public void sum(int x,int y,int z )
		{

			Console.WriteLine(x + y -z);



		}



	}
	class Main1
	{


        static void Main(string[] args)
        {
			MethodOverloading M = new MethodOverloading();
			M.sum(1, 7);
			M.sum(1, 20,9);
		}

    }
}
