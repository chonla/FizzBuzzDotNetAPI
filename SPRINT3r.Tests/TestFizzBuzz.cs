using NUnit.Framework;
using System;
using SPRINT3r;

namespace TestSPRINT3r
{
	[TestFixture()]
	public class TestFizzBuzz
	{
		[Test()]
		public void ItShouldCount1()
		{
			var fizzBuzz = new FizzBuzz();
			Assert.AreEqual("1", fizzBuzz.count(1));
		}
	}
}
