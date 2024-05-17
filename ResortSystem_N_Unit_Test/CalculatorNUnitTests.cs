using NUnit.Framework;
using ResortSystem;

namespace ResortSystem_N_Unit_Test
{
	[TestFixture]
	public class CalculatorNUnitTests
	{
		[Test]
		public void AddNumbers_InputTwoInt_GetCorrectAddition()
		{
			//Arrange
			Calculator calc = new();

			//Act
			int result = calc.AddNumbers(10, 20);

			//Assert 
			Assert.AreEqual(30, result);

		}

		[Test]
		public void IsOddChecker_InputEvenNumber_ReturnFalse()
		{
			Calculator calc = new();
			bool isOdd = calc.IsOddNumber(10);
			Assert.IsFalse(isOdd);
		}

		[Test]
		[TestCase(11)]
		[TestCase(13)]
		public void IsOddChecker_InputOffNumber_ReturnTrue(int a)
		{ 
			Calculator calc = new();
			bool isOdd = calc.IsOddNumber(a);
			Assert.IsTrue(isOdd);
		}

		[Test]
		[TestCase(8, ExpectedResult = false)]
		[TestCase(11, ExpectedResult = true)]

		public bool IsOddChecker_InputOffNumber_ReturnTrueIfOdd(int a)
		{
			Calculator calc = new();
			return calc.IsOddNumber(a);
		
		}



		}
}
