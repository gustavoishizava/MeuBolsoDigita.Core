using System;
using MeuBolsoDigital.Core.Assertions;
using MeuBolsoDigital.Core.Exceptions;
using Xunit;

namespace MeuBolsoDigital.Core.UnitTests.Assertions;

public class IsNotNullAndIsNotNullOrEmptyTests
{
    [Fact]
    public void Object_ReturnDomainException()
    {
        // Arrange
        var randomMessage = Guid.NewGuid().ToString();
        object value = null;

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsNotNull(value, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void String_ReturnDomainException(string value)
    {
        // Arrange
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsNotNullOrEmpty(value, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }
}
