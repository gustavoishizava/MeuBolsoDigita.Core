using System;
using MeuBolsoDigital.Core.Assertions;
using MeuBolsoDigital.Core.Exceptions;
using Xunit;

namespace MeuBolsoDigital.Core.UnitTests.Assertions;

public class IsNotEmptyTests
{
    [Fact]
    public void EmptyValue_ReturnDomainException()
    {
        // Arrange
        string randomMessage = Guid.NewGuid().ToString();

        // Act & Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsNotEmpty(Guid.Empty, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void Nullabe_EmptyValue_ReturnDomainException()
    {
        // Arrange
        string randomMessage = Guid.NewGuid().ToString();
        Guid? value = Guid.Empty;

        // Act & Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsNotEmpty(value, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }
}
