using NUnit.Framework;
using System;
using SPRINT3r;

namespace TestSPRINT3r
{
	[TestFixture()]
	public class TestFizzBuzz
	{
		FizzBuzz fizzBuzz;

		[SetUp]
		public void Setup()
		{
			fizzBuzz = new FizzBuzz();	
		}

		[Test()]
		public void ItShouldCount1()
		{
			Assert.AreEqual("1", fizzBuzz.count(1));
		}

		[Test()]
		public void ItShouldCount2()
		{
			Assert.AreEqual("2", fizzBuzz.count(2));
		}
	}
}
