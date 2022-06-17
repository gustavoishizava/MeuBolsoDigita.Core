using System;
using MeuBolsoDigital.Core.Assertions;
using MeuBolsoDigital.Core.Exceptions;
using Xunit;

namespace MeuBolsoDigital.Core.UnitTests.Assertions;

public class RegexTests
{
    [Fact]
    public void OnlyNumbers_ReturnDomainException()
    {
        // Arrange
        string value = "abc";
        var pattern = @"^\d$";
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.ArgumentMatches(value, pattern, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }
}
