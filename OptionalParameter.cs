using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_yogeshDemo
{
	internal class OptionalParameter
	{

		public  int OptionalParamter(int x , int y, int z = 66)
		{

			return x * y +z;
		}

		static void Main(string[] args)
        {

			OptionalParameter obj = new OptionalParameter();


			int val = obj.OptionalParamter(1, 2, 3);
			 
			int val1 = obj.OptionalParamter(2, 3);
			Console.WriteLine(val);
			Console.WriteLine(val1);

		}
    }
}
