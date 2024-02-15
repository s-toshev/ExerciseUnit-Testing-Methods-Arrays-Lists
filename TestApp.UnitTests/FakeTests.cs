using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        //Arrange
        char[] strings = { 'm', 'i','6', 'x','1','3' };

        //Act
        char[] actual = Fake.RemoveStringNumbers(strings);
        char[] expected = { 'm', 'i', 'x' };
        //Assert
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        //Arrange
        char[] strings = { 'm','i','x' };

        //Act
        char[] actual = Fake.RemoveStringNumbers(strings);
        char[] expected = { 'm', 'i', 'x' };
        //Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        //Arrange
        char[] strings = Array.Empty<char>();

        //Act
        char[] actual = Fake.RemoveStringNumbers(strings);
        char[] expected = Array.Empty<char>();
        //Assert
        Assert.AreEqual(expected, actual);

    }
}
