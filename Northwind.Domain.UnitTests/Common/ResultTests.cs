using FluentAssertions;
using Northwind.Domain.Common;
using Xunit;

namespace Northwind.Domain.UnitTests.Common
{
    public class ResultTests
    {
        [Fact]
        public void Result_Success_DeberiaTenerIsSuccessTrueYErrorNull()
        {
            // Act
            var result = Result.Success();

            // Assert
            result.IsSuccess.Should().BeTrue();
            result.Error.Should().BeNull();
        }

        [Fact]
        public void Result_Failure_DeberiaTenerIsSuccessFalseYMensajeDeError()
        {
            // Act
            var result = Result.Failure("Ocurrió un error inesperado");

            // Assert
            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Be("Ocurrió un error inesperado");
        }

        [Fact]
        public void ResultT_Success_DeberiaTenerIsSuccessTrueYValor()
        {
            // Act
            var result = Result<int>.Success(42);

            // Assert
            result.IsSuccess.Should().BeTrue();
            result.Value.Should().Be(42);
            result.Error.Should().BeNull();
        }

        [Fact]
        public void ResultT_Failure_DeberiaTenerIsSuccessFalseYError()
        {
            // Act
            var result = Result<string>.Failure("Dato no encontrado");

            // Assert
            result.IsSuccess.Should().BeFalse();
            result.Value.Should().BeNull();
            result.Error.Should().Be("Dato no encontrado");
        }
    }
}
