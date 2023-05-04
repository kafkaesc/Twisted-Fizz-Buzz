using TwistedFizzBuzz;

namespace TwistedFizzBuzzTest;
[TestClass]
public class UnitTest
{
    [TestMethod]
    public void FizzBuzzOneArgTest()
    {
        String integer = TwistedFizzBuzz.Util.FizzBuzz(1);
        String fizz = TwistedFizzBuzz.Util.FizzBuzz(3);
        String buzz = TwistedFizzBuzz.Util.FizzBuzz(5);
        String fizzBuzz = TwistedFizzBuzz.Util.FizzBuzz(15);
        Assert.IsTrue(integer == "1");
        Assert.IsTrue(fizz == "Fizz");
        Assert.IsTrue(buzz == "Buzz");
        Assert.IsTrue(fizzBuzz == "FizzBuzz");
    }

    [TestMethod]
    public void FizzBuzzRangeArgTest()
    {
        String tenTo10 = TwistedFizzBuzz.Util.FizzBuzz(10, 10);
        String tenTo15 = TwistedFizzBuzz.Util.FizzBuzz(10, 15);
        String negativeSeventoNegative18 = TwistedFizzBuzz.Util.FizzBuzz(
            -7,
            -18
        );
        Assert.IsTrue(tenTo10 == "Buzz");
        Assert.IsTrue(tenTo15 == "Buzz\n11\nFizz\n13\n14\nFizzBuzz");
		Assert.IsTrue(negativeSeventoNegative18 ==
            "-7\n-8\nFizz\nBuzz\n-11\nFizz\n-13\n-14\nFizzBuzz\n-16\n-17\nFizz"
        );
	}

    [TestMethod]
    public void FizzBuzzArrayArgTest()
    {
        int[] placebo = { 4, 7, 2, 3, 9, 8, 5 };
		String placeboFizzBuzz = TwistedFizzBuzz.Util.FizzBuzz(placebo);
        Assert.IsTrue(placeboFizzBuzz == "4\n7\n2\nFizz\nFizz\n8\nBuzz");
    }

    [TestMethod]
    public void FizzBuzzSetTest()
    {
        TwistedFizzBuzz.Util.SetFizzBuzz("flibber", 4, "ti", 5, "gibbet", 6);
        int[] flibbertigibbet = { 1, 4, 5, 6, 7, 120 };
        String flibbertigibbetFizzBuzz = TwistedFizzBuzz.Util.FizzBuzz(
            flibbertigibbet
        );
        Assert.IsTrue(flibbertigibbetFizzBuzz ==
            "1\nflibber\nti\ngibbet\n7\nflibbertigibbet");
    }

    [TestMethod]
    public void FizzBuzzResetTest()
    {
		TwistedFizzBuzz.Util.SetFizzBuzz("flibber", 4, "ti", 5, "gibbet", 6);
        TwistedFizzBuzz.Util.ResetFizzBuzz();
		String integer = TwistedFizzBuzz.Util.FizzBuzz(1);
		String fizz = TwistedFizzBuzz.Util.FizzBuzz(3);
		String buzz = TwistedFizzBuzz.Util.FizzBuzz(5);
		String fizzBuzz = TwistedFizzBuzz.Util.FizzBuzz(15);
		Assert.IsTrue(integer == "1");
		Assert.IsTrue(fizz == "Fizz");
		Assert.IsTrue(buzz == "Buzz");
		Assert.IsTrue(fizzBuzz == "FizzBuzz");
	}

    [TestMethod]
    public void FizzBuzzFromApi()
    {
		FizzBuzzApiResponse fbar = new FizzBuzzApiResponse(2, "even");
        TwistedFizzBuzz.Util.SetFizzBuzz(fbar);
        String fizzBuzzString = TwistedFizzBuzz.Util.FizzBuzz(1, 6);
        Assert.IsTrue(fizzBuzzString == "1\neven\n3\neven\n5\neven");
    }
}
