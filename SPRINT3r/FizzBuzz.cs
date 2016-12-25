using System;
namespace SPRINT3r
{
	public class FizzBuzz
	{
		public FizzBuzz()
		{
		}

		public string Count(int v)
		{
			if (isBuzz(v) && IsFizz(v))
			{
				return "FizzBuzz";
			}
			if (IsFizz(v))
			{
				return "Fizz";
			}
			if (isBuzz(v))
			{
				return "Buzz";
			}
			return v.ToString();
		}

		static bool IsFizz(int v)
		{
			return v % 3 == 0;
		}

		static bool isBuzz(int v)
		{
			return v % 5 == 0;
		}
	}
}
