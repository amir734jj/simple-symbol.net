using System;
using simple.symbol.net;
using Xunit;

namespace simple_symbol.net.tests
{
    public class SymbolTest
    {
        [Fact]
        public void Test__ToString()
        {
            // Arrange
            var symbol = Symbol.Of("Test");

            // Act, Assert
            Assert.Equal("'Test", symbol.ToString());
        }
        
        [Fact]
        public void Test__HashCode()
        {
            // Arrange
            var symbol1 = Symbol.Of("Test1");
            var symbol2 = Symbol.Of("Test2");

            // Act, Assert
            Assert.NotEqual(symbol1.GetHashCode(), symbol2.GetHashCode());
        }
        
        [Fact]
        public void Test__Persistent()
        {
            // Arrange
            var symbol1 = Symbol.Of("Test");
            var symbol2 = Symbol.Of("Test");

            // Act, Assert
            // ReSharper disable once PossibleUnintendedReferenceComparison
            Assert.True(symbol1 == symbol2);
        }
        
        [Fact]
        public void Test__Value()
        {
            // Arrange
            var symbol = Symbol.Of("Test");

            // Act, Assert
            // ReSharper disable once PossibleUnintendedReferenceComparison
            Assert.Equal("Test", symbol.Value);
        }
    }
}