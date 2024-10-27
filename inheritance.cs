using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_yogeshDemo
{
	class Parent
	{

		public void method1(int parentid,string Parentname)
		{

            Console.WriteLine("this method of parent class  id :{0} ,name {1}", parentid, Parentname);

		}



	}

	class child : Parent
	{



		static void Main(string[] args)
		{
			Parent P = new Parent();
			P.method1(1, "Aman");

		}



	}
}
