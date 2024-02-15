using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@jairocg.net";

        // Act
        bool actual = Email.IsValidEmail(validEmail);
        bool expected = true;

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestCase(null, false)]
    [TestCase(" ", false)]
    [TestCase("noValidMail", false)]
    [TestCase("noValidMail.net", false)]
    [TestCase("noValidMail@net", false)]
    public void Test_IsValidEmail_InvalidEmail(string invalidMail, bool expected)
    {
        // Arrange

        // Act
        bool actual = Email.IsValidEmail(invalidMail);  
        // Assert
        Assert.AreEqual(expected, actual);

        }

}
