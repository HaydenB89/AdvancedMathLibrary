using System;

namespace AdvancedMathLibrary {

    public static class Math {
        public const int Zero = 0;

        public static int AbsoluteValue(int a) { //abs vals only have one parameter
            return (a < 0) ? -a : a;
        }
        public static int Add(int a, int b) {
            return a + b;
        }
        public static int Sub(int a, int b) {
            return a - b;
        }
        public static int Mult(int a, int b) {
            return a * b;
        }
        public static int Div(int a, int b) {
            return a / b;
        }
    }
}
