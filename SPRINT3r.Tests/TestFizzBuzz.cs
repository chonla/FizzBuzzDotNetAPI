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

		[TestCase(1)]
		[TestCase(2)]
		public void ItShouldCountNormal(int value)
		{
			Assert.AreEqual(value.ToString(), fizzBuzz.count(value));
		}

		[TestCase(3)]
		[TestCase(6)]
		public void ItShouldCountFizz(int value)
		{
			Assert.AreEqual("Fizz", fizzBuzz.count(value));
		}

		[TestCase(5)]
		[TestCase(10)]
		public void ItShouldCountBuzz(int value)
		{
			Assert.AreEqual("Buzz", fizzBuzz.count(value));
		}

		[TestCase(15)]
		[TestCase(30)]
		public void ItShouldCountFizzBuzz(int value)
		{
			Assert.AreEqual("FizzBuzz", fizzBuzz.count(value));
		}
	}
}
