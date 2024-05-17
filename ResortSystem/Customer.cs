using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortSystem
{
	public class Customer
	{
		public string GreetMessage{ get; set; }
		public string GreetAndCombineNames(string a, string b)
		{
			GreetMessage = $"hello, {a} {b}";
			return GreetMessage;

		}
	}
}
