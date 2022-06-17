using System;
using MeuBolsoDigital.Core.Assertions;
using MeuBolsoDigital.Core.Exceptions;
using Xunit;

namespace MeuBolsoDigital.Core.UnitTests.Assertions;

public class IsLowerOrEqualsThanTests
{
    [Fact]
    public void DateTime_ReturnDomainException()
    {
        // Arrange
        DateTime value = DateTime.Now;
        DateTime comparer = value.AddDays(-1);
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsLowerOrEqualsThan(value, comparer, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void NullableDateTime_ReturnDomainException()
    {
        // Arrange
        DateTime? value = DateTime.Now;
        DateTime comparer = value.Value.AddDays(-1);
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsLowerOrEqualsThan(value, comparer, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void Decimal_ReturnDomainException()
    {
        // Arrange
        decimal value = 1;
        decimal comparer = 0;
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsLowerOrEqualsThan(value, comparer, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void NullableDecimal_ReturnDomainException()
    {
        // Arrange
        decimal? value = 1;
        decimal comparer = 0;
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsLowerOrEqualsThan(value, comparer, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void Double_ReturnDomainException()
    {
        // Arrange
        double value = 1;
        double comparer = 0;
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsLowerOrEqualsThan(value, comparer, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void NullableDouble_ReturnDomainException()
    {
        // Arrange
        double? value = 1;
        double comparer = 0;
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsLowerOrEqualsThan(value, comparer, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void Float_ReturnDomainException()
    {
        // Arrange
        float value = 1;
        float comparer = 0;
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsLowerOrEqualsThan(value, comparer, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void NullableFloat_ReturnDomainException()
    {
        // Arrange
        float? value = 1;
        float comparer = 0;
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsLowerOrEqualsThan(value, comparer, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void Int_ReturnDomainException()
    {
        // Arrange
        int value = 1;
        int comparer = 0;
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsLowerOrEqualsThan(value, comparer, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void NullableInt_ReturnDomainException()
    {
        // Arrange
        int? value = 1;
        int comparer = 0;
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsLowerOrEqualsThan(value, comparer, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void Long_ReturnDomainException()
    {
        // Arrange
        long value = 1;
        long comparer = 0;
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsLowerOrEqualsThan(value, comparer, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }

    [Fact]
    public void NullableLong_ReturnDomainException()
    {
        // Arrange
        long? value = 1;
        long comparer = 0;
        var randomMessage = Guid.NewGuid().ToString();

        // Act && Assert
        var exception = Assert.Throws<DomainException>(() => DomainAssertions.IsLowerOrEqualsThan(value, comparer, randomMessage));
        Assert.Equal(randomMessage, exception.Message);
    }
}
