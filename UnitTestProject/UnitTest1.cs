using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MathProgram;

namespace UnitTestProject
{
	[TestClass]
	public class UnitTest1
	{

		[TestMethod]
		public void Test_Add()
		{
			MathHelper mathHelper = new MathHelper();
			int result = mathHelper.Add(10, 10);
			Assert.AreEqual(20, result);
		}




		[TestMethod]
		public void Test_Subtract()
		{
			MathHelper mathHelper = new MathHelper();
			int result = mathHelper.Subtract(10, 10);
			Assert.AreEqual(0, result);
		}

	}
}
