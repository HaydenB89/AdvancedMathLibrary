
using AdvancedMathLibrary;
using Xunit;

namespace TestAdvMathLibrary {
    public class TestIntMathLib {

        [Fact]
        public void TestAbsoluteValue() {   //test methods ALWAYS return void w/no parameters
            int answer = Math.AbsoluteValue(-3);
            Assert.Equal(3, answer);
        }
    }
}
