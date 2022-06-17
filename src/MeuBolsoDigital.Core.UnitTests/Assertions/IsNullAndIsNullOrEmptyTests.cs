using System;
using MeuBolsoDigital.Core.Assertions;
using MeuBolsoDigital.Core.Exceptions;
using Xunit;

namespace MeuBolsoDigital.Core.UnitTests.Assertions;

public class IsNullAndIsNullOrEmptyTests
{
    [Fact]
    public void Object_ReturnDomainException()
    {
        // Arrange
        var randomMessage = Guid.NewGuid().ToString();
        object value = new { };

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsNull(value, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void String_ReturnDomainException()
    {
        // Arrange
        var randomMessage = Guid.NewGuid().ToString();
        string value = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsNullOrEmpty(value, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }
}
