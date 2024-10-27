using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_yogeshDemo
{
	internal class NamedParameter
	{
		public void method(int a , int b , string name )
		{

			Console.WriteLine(" this is method  of named parameter {0},{1},{2}", a, b, name);



		}

		static void Main(string[] args)
        {


			NamedParameter N = new NamedParameter();

            N.method(a:33,name : "YOPP",b:60);




		}







    }
}
