using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [TestCase(0, 0)]
    [TestCase(1, 1)]
    [TestCase(5, 5)]
    [TestCase(23, 28657)]
    public void Test_CalculateFibonacci_ZeroInput(int input, int expected)
    {
        //Arrange


        //Act
        int actual = Fibonacci.CalculateFibonacci(input);

        //Assert
        Assert.AreEqual(expected, actual);

    }

}