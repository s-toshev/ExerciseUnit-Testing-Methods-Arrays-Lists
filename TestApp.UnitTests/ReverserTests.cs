using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverserTests
{
    [Test]
    public void Test_ReverseStrings_WithEmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        string[] inputArray = Array.Empty<string>();

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_ReverseStrings_WithSingleString_ReturnsReversedString()
    {
        // Arrange
        string[] arr = new string[] { "naomI" };
        // Act
        string[] actual = Reverser.ReverseStrings(arr);
        string[] expected = new string[] { "Imoan" };
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ReverseStrings_WithMultipleStrings_ReturnsReversedStrings()
    {
        // Arrange
        string[] arr = new string[] { "naomI", "xiMehTni" };
        // Act
        string[] actual = Reverser.ReverseStrings(arr);
        string[] expected = new string[] { "Imoan", "inTheMix" };
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ReverseStrings_WithSpecialCharacters_ReturnsReversedSpecialCharacters()
    {
        // Arrange
        string[] arr = new string[] { "naomI$$$", "###xiMehTni%%$$" };
        // Act
        string[] actual = Reverser.ReverseStrings(arr);
        string[] expected = new string[] { "$$$Imoan", "$$%%inTheMix###" };
        // Assert
        Assert.AreEqual(expected, actual);
    }
}
