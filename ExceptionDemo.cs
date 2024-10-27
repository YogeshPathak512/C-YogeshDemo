using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_yogeshDemo
{
    internal class ExceptionDemo
    {

		static void Main(string[] args)
		{

			try
			{
				Console.WriteLine("Enter two numberrs ");
				int a = Convert.ToInt32(Console.ReadLine());
				int b = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(a / b);
			}

			catch (DivideByZeroException ex)
			{ Console.WriteLine("Thats bad trying to divide by zero"); }
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine(e.StackTrace);
			}

			finally
			{
				Console.WriteLine(" Main");
			}

		}



	}
}

