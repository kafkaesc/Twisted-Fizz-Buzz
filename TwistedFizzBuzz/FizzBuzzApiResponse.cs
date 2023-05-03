using System;
namespace TwistedFizzBuzz
{
	public class FizzBuzzApiResponse
	{
		public int multiple;
		public String word;

		public FizzBuzzApiResponse(int multiple, String word)
		{
			this.multiple = multiple;
			this.word = word;
		}
	}
}

