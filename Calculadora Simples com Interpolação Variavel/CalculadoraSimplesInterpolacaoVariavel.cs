public class CalculadoraInterpolacao
    {
        public void Somar(double x, double y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(double x, double y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(double x, double y)
        {
            Console.WriteLine($"{x} X {y} = {x * y}");
        }

        public void Dividir(double x, double y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(double x, double y)
        {
            double pot  = Math.Pow(x, y);
            Console.WriteLine($"{x} potência de {y} = {pot}");
        }
    }
