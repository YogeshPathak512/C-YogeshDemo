using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_yogeshDemo
{
	internal class CustomException:Exception
	{
		public string message { get; set; }

		public CustomException()
		{
			message = "Hello there is error in Program";
		}
		public CustomException(string message)
		{
			this.message = message;
		}




	}
}
