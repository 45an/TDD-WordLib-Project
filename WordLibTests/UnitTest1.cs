using WordLib;
namespace WordLibTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void IsPalindrome()
    {
        // Create an instance to test:
        Worder worder = new Worder();

        // expected output
        string expectedResult = "radar";
        string inputWord = "radar";
        // Run the method under test:
        string actualResult = worder.IsPalindromeWordChecker(inputWord);

        // Assert / Verify the result:
        Assert.AreEqual(expectedResult, actualResult);


    }

    [TestMethod]

    public void IsPalindromeThrowsException()
    {
        Worder worder = new Worder();
        string inputWord = null;

        Assert.ThrowsException<ArgumentException>(() => worder.IsPalindromeWordChecker(inputWord));


    }



}


