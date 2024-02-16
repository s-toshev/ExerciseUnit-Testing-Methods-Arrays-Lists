using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> strings = new List<string> {"kayak" };
        // Act
        bool actual = Palindrome.IsPalindrome(strings);
        bool expected = true;
        // Assert
        Assert.AreEqual(expected, actual);
    }

    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> strings = new List<string> ();
        // Act
        bool actual = Palindrome.IsPalindrome(strings);
        bool expected = true;
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> strings = new List<string> { "wow" };
        // Act
        bool actual = Palindrome.IsPalindrome(strings);
        bool expected = true;
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> strings = new List<string> { "kravyak" };
        // Act
        bool actual = Palindrome.IsPalindrome(strings);
        bool expected = false;
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> strings = new List<string> { "kAyak","roTatoR","deeD" };
        // Act
        bool actual = Palindrome.IsPalindrome(strings);
        bool expected = true;
        // Assert
        Assert.AreEqual(expected, actual);
    }
}
