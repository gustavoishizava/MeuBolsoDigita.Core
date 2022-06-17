using System;
using MeuBolsoDigital.Core.Assertions;
using MeuBolsoDigital.Core.Exceptions;
using Xunit;

namespace MeuBolsoDigital.Core.UnitTests.Assertions;

public class StringTests
{
    [Fact]
    public void HasMinLength_ReturnDomainException()
    {
        // Arrange
        string value = "a";
        int min = 2;
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.HasMinLength(value, min, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void HasMaxLength_ReturnDomainException()
    {
        // Arrange
        string value = "abc";
        int max = 1;
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.HasMaxLength(value, max, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Theory]
    [InlineData("a")]
    [InlineData("abcde")]
    public void HasMinAndMaxLength_ReturnDomainException(string value)
    {
        // Arrange
        int min = 2;
        int max = 3;
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.HasMinAndMaxLength(value, min, max, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void HasLength_ReturnDomainException()
    {
        // Arrange
        string value = "abc";
        int length = 1;
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.HasLength(value, length, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void Contais_ReturnDomainException()
    {
        // Arrange
        string value = "abc";
        string text = "def";
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.Contains(value, text, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }
}
