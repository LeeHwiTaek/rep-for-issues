namespace AnaliticalFunctionLib {
    public class AnaliticalFunction {
        public static double Calcualte(int x) {
            if (x < 1) {
                return Math.Pow(x, 2);
            } else if (x < 3) {
                return Math.Pow(x, 3);
            } else {
                return x * 3;
            }
        }
    }
}