using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        //Arrange
        int[] arr = new int[] { 1, 1, 3, 5, 7 };

        //Act
        int[] actual = Pattern.SortInPattern(arr);
        int[] expected = new int[] { 1, 7, 3, 5 };


        //Assert

        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        //Arrange
        int[] arr = Array.Empty <int>();

        //Act
        int[] actual = Pattern.SortInPattern(arr);

        //Assert
        Assert.AreEqual(Array.Empty<int>(), actual);

    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        //Arrange
        int[] arr = new int[] { 7 };

        //Act
        int[] actual = Pattern.SortInPattern(arr);
        int[] expected = new int[] { 7 };


        //Assert

        Assert.AreEqual(expected, actual);

    }
}
