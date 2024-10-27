using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_yogeshDemo
{
	internal class parameterArray
	{
		public int Method(params int[] arr)
		{

			int sum = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				sum = sum+ arr[i];

			}
			return sum;


		}

		static void Main(string[] args)
		{

			parameterArray obj = new parameterArray();
			int sum = obj.Method(12, 2, 7);

			Console.WriteLine("The sum of array " + sum);

			
		}

	}
}
