using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        int[] actual = Duplicates.RemoveDuplicates(numbers);
        int[] expected = Array.Empty<int>();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int[] numbers = new int[] { 1, 2, 4, 7 };
        // Act
        int[] actual = Duplicates.RemoveDuplicates(numbers);
        int[] expected = new int[] { 1, 2, 4, 7 };

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        // Arrange
        int[] numbers = new int[] { 1, 1, 2, 4, 7, 4, 5 };
        // Act
        int[] actual = Duplicates.RemoveDuplicates(numbers);
        int[] expected = new int[] { 1, 2, 4, 7, 5 };

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        // Arrange
        int[] numbers = new int[] { 1, 1 };
        // Act
        int[] actual = Duplicates.RemoveDuplicates(numbers);
        int[] expected = new int[] { 1 };

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
