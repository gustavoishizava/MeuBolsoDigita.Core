using System;
using MeuBolsoDigital.Core.Assertions;
using MeuBolsoDigital.Core.Exceptions;
using Xunit;

namespace MeuBolsoDigital.Core.UnitTests.Assertions;

public class BooleanTests
{
    [Fact]
    public void ValueFalse_IsTrue_ReturnDomainException()
    {
        // Arrange
        string randomMessage = Guid.NewGuid().ToString();

        // Act & Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsTrue(false, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void ValueTrue_IsFalse_ReturnDomainException()
    {
        // Arrange
        string randomMessage = Guid.NewGuid().ToString();

        // Act & Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsFalse(true, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }
}
