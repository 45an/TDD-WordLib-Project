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
        string palindrome = "radar";

        // Run the method under test:
        bool result = worder.IsPalindrome(palindrome);

        // Assert / Verify the result:
        Assert.IsTrue(result);
    }
}
