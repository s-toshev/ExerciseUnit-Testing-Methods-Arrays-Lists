using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        //Arrange
        long num = 99999989L;

        //Act
        long actual = PrimeFactor.FindLargestPrimeFactor(num);

        long expected = 99999989;
        //Assert
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        //Arrange
        long num = 1234567890123456789L; 

        //Act
        long actual = PrimeFactor.FindLargestPrimeFactor(num);

        long expected = 27961;
        //Assert
        Assert.AreEqual(expected, actual);

    }
}
