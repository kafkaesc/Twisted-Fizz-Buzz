namespace TwistedFizzBuzz;

public static class Util
{
	private const String defaultFizz = "Fizz";
	private const String defaultBuzz = "Buzz";
	private const String defaultTern = "Tern";

	static String fizz = defaultFizz;
	static int fizzDivisor = 3;
	static String buzz = defaultBuzz;
	static int? buzzDivisor = 5;
	static String tern = defaultTern;
	static int? ternDivisor = null;

	/* Returns the corresponding FizzBuzz string/int for the given int n */
	public static String FizzBuzz(int n)
	{
		String fizzBuzzString = "";
		if (n % fizzDivisor == 0)
			fizzBuzzString += fizz;
		if (buzzDivisor != null && n % buzzDivisor.Value == 0)
			fizzBuzzString += buzz;
		if (ternDivisor != null && n % ternDivisor.Value == 0)
			fizzBuzzString += tern;
		if (fizzBuzzString.Length == 0)
			fizzBuzzString += n;
		return fizzBuzzString;
	}

	/* Accept user input for a range of numbers and returns their FizzBuzz 
	 * output, e.g., 1-50; 1-2,000,000,000; or (-2)-(-37). */
	public static String FizzBuzz(int start, int end)
	{
		String output = "";
		if (start < end)
			for (var i = start; i <= end; i++)
				output += FizzBuzz(i) + "\n";
		else if (start > end)
			for (var i = start; i >= end; i--)
				output += FizzBuzz(i) + "\n";
		else
			output += FizzBuzz(start) + "\n";
		return output.Substring(0, output.Length - 1);
	}

	/* Accept user input of a non-sequential set of numbers and returns 
	 * their FizzBuzz output, e.g., -5, 6, 300, 12, 15. */
	public static String FizzBuzz(int[] userInput)
	{
		String output = "";
		for (var j = 0; j < userInput.Length; j++)
			output += FizzBuzz(userInput[j]) + "\n";
		return output.Substring(0, output.Length - 1);
	}

	/* Reset the class variables to the default state. */
	public static void ResetFizzBuzz()
	{
		fizz = defaultFizz;
		fizzDivisor = 3;
		buzz = defaultBuzz;
		buzzDivisor = 5;
		tern = defaultTern;
		ternDivisor = null;
	}

	/* Accept user input for alternative tokens instead of "Fizz" and "Buzz" 
	 * and alternative divisors instead of 3 and 5. For example, 7, 17, and 3 
	 * would use "Poem", "Writer", and "College". 119 would output "PoemWriter",
	 * 51 would output "WriterCollege", 21 would output "PoemCollege, and 357 
	 * would output "PoemWriterCollege". */
	public static void SetFizzBuzz(
		String fizzName,
		int? fizzDiv,
		String? buzzName = null,
		int? buzzDiv = null,
		String? ternName = null,
		int? ternDiv = null
	) {
		if (fizzName != null)
			fizz = fizzName;
		if (fizzDiv != null)
			fizzDivisor = fizzDiv.Value;
		if (buzzName != null)
			buzz = buzzName;
		if (buzzDiv != null)
			buzzDivisor = buzzDiv.Value;
		else if (buzzDiv == null)
			buzzDivisor = null;
		if (ternName != null)
			tern = ternName;
		if (ternDiv != null)
			ternDivisor = ternDiv.Value;
	}

	/* Accept user input for API generated tokens provided by 
	 * https://rich-red-cocoon-veil.cyclic.app/ */
	public static void SetFizzBuzz(FizzBuzzApiResponse fbar)
	{
		SetFizzBuzz(fbar.word, fbar.multiple, null, null);
	}
}
