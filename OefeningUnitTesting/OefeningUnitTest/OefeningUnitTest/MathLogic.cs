namespace OefeningUnitTest
{
    public class MathLogic
    {
        public Double Som(Double x, Double y)
        {
            return x + y;
        }

        public Double Verschil(Double x, Double y)
        {
            return x - y;
        }

        public Double Product(Double x, Double y)
        {
            return x * y;
        }

        public Double Delen(Double x, Double y)
        {
            if (y == 0) throw new DivideByZeroException();
            return x / y;
        }
    }
}