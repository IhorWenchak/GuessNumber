using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuessNumber;

namespace UnitTest_GuessNumber
{
	[TestClass]
	public class UnitTest1
	{
		GuessManager gs = new GuessManager();

		[TestMethod]
		public void TestMethod_Parsing()
		{
			gs.GivenString = "4@7";

			bool result = gs.IsNumber;

			bool expected = false;

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void TestMethod_GetNumber()
		{
			gs.GivenString = "99";

			bool parse = gs.IsNumber;

			int result = gs.GivenNumber;

			int expected = 99;

			Assert.AreEqual(expected, result);
		}
	}
}
