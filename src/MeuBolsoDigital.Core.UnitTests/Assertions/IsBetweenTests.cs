using System;
using MeuBolsoDigital.Core.Assertions;
using MeuBolsoDigital.Core.Exceptions;
using Xunit;

namespace MeuBolsoDigital.Core.UnitTests.Assertions;

public class IsBetweenTests
{
    [Fact]
    public void DateTime_ReturnDomainException()
    {
        // Arrange
        DateTime value = DateTime.Now;
        DateTime from = value.AddDays(1);
        DateTime to = value.AddDays(2);
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsBetween(value, from, to, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void NullableDateTime_ReturnDomainException()
    {
        // Arrange
        DateTime? value = DateTime.Now;
        DateTime from = value.Value.AddDays(1);
        DateTime to = value.Value.AddDays(2);
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsBetween(value, from, to, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void Decimal_ReturnDomainException()
    {
        // Arrange
        decimal value = 0;
        decimal from = 1;
        decimal to = 2;
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsBetween(value, from, to, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void NullableDecimal_ReturnDomainException()
    {
        // Arrange
        decimal? value = 0;
        decimal from = 1;
        decimal to = 2;
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsBetween(value, from, to, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void Double_ReturnDomainException()
    {
        // Arrange
        double value = 0;
        double from = 1;
        double to = 2;
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsBetween(value, from, to, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void NullableDouble_ReturnDomainException()
    {
        // Arrange
        double? value = 0;
        double from = 1;
        double to = 2;
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsBetween(value, from, to, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void Float_ReturnDomainException()
    {
        // Arrange
        float value = 0;
        float from = 1;
        float to = 2;
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsBetween(value, from, to, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void NullableFloat_ReturnDomainException()
    {
        // Arrange
        float? value = 0;
        float from = 1;
        float to = 2;
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsBetween(value, from, to, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void Int_ReturnDomainException()
    {
        // Arrange
        int value = 0;
        int from = 1;
        int to = 2;
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsBetween(value, from, to, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void NullableInt_ReturnDomainException()
    {
        // Arrange
        int? value = 0;
        int from = 1;
        int to = 2;
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsBetween(value, from, to, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void Long_ReturnDomainException()
    {
        // Arrange
        long value = 0;
        long from = 1;
        long to = 2;
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsBetween(value, from, to, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void NullableLong_ReturnDomainException()
    {
        // Arrange
        long? value = 0;
        long from = 1;
        long to = 2;
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsBetween(value, from, to, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }
}
