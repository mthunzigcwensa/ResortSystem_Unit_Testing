using NUnit.Framework;
using NUnit.Framework.Internal;
using ResortSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortSystem_N_Unit_Test
{
	[TestFixture]
	public class CustomerNUnitTests
	{

		private Customer customer;
		[SetUp]
		public void Setup() { 
		
			customer = new Customer();

		}


		[Test]
		public void CombineName_InputFirstAndLastName_ReturnFullName()
		{
			//Arrange
			

			//Act
			string fullname = customer.GreetAndCombineNames("see","me");

			//Assert
			Assert.That(fullname, Is.EqualTo("hello, see me"));
			Assert.That(fullname, Does.Contain("see mE").IgnoreCase);
			Assert.That(fullname, Does.StartWith("hello"));
			Assert.That(fullname, Does.EndWith("me"));
		}
		[Test]
		public void GreetMessage_NotGreeted_ReturnNull()
		{
			
			//customer.GreetAndCombineNames("see", "me");
			Assert.IsNull(customer.GreetMessage);
		}
	}
} 
