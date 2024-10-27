using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_yogeshDemo
{
	internal class InterfaceDemo
	{

        static void Main(string[] args)
        {
			CompanyEmployee obj = new CompanyEmployee();
		   

			IEmployee1 obj1 = new CompanyEmployee();
			obj1.EmpShowName();


			IEmployee obj2 = new CompanyEmployee();
			obj2.EmpShowName();


		}




    }
}
