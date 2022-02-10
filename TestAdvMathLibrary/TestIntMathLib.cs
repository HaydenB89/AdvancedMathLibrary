
using AdvancedMathLibrary;
using Xunit;

namespace TestAdvMathLibrary {
    public class TestIntMathLib {
        /*--commented out to run same as [Theory]
        [Fact]
        public void TestAbsoluteValue() {   //test methods ALWAYS return void w/no parameters
            int answer = Math.AbsoluteValue(-3);
            Assert.Equal(3, answer);
            //testing with 3
            Assert.Equal(3, Math.AbsoluteValue(3));
            Assert.Equal(0, Math.AbsoluteValue(0));
        }
        */
        [Fact]
        public void TestZeroConstant() {
            Assert.Equal(0, Math.Zero);
        }

        [Theory]
        [InlineData(-3,3)]           // [Theory] allows you to Test [Fact] 
        [InlineData(3,3)]            //but with less code by using [InlineData()]
        [InlineData(0, 0)]
        public void TestAbsoluteValue(int input, int expected) {   //theory methods ALWAYS return void WITH parameters
            int answer = Math.AbsoluteValue(input);
            Assert.Equal(expected, answer);
        }

        [Theory]
        [InlineData(0,0,0)]
        [InlineData(0,5,-5)]
        [InlineData(-10, 15, -25)]
        public void TestAdd(int expected, int a, int b) {
            Assert.Equal(expected, Math.Add(a, b));
        }

        [Theory]
        [InlineData(0,0,0)]
        [InlineData(0, 5, 5)]
        [InlineData(10, 20, 10)]
        [InlineData(-3, 3, 6)]
        [InlineData(6, 3, -3)]
        public void TestSub(int expected, int a, int b) {
            Assert.Equal(expected, Math.Sub(a, b));
        }

        [Theory]
        [InlineData(0, 0, 1)]
        [InlineData(25, 5, 5)]
        [InlineData(10, 2, 5)]
        [InlineData(-3, 1, -3)]
        [InlineData(9, 3, 3)]
        public void TestMult(int expected, int a, int b) {
            Assert.Equal(expected, Math.Mult(a, b));
        }

        [Theory]
        [InlineData(0, 0, 1)]
        [InlineData(9, 81, 9)]
        [InlineData(10, 20, 2)]
        [InlineData(-1, -3, 3)]
        [InlineData(6, 36, 6)]
        public void TestDiv(int expected, int a, int b) {
            Assert.Equal(expected, Math.Div(a, b));
        }

        [Fact]
        public void TestDivideByZero() {
            System.Action ZeroDenominator = () => Math.Div(1, 0);           //calling from the MathLib using System then naming the Div method 'ZeroDenominator'
            Assert.Throws<System.DivideByZeroException>(ZeroDenominator);   //throw an exception for dividing by 0
        }

    }
}
