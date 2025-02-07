namespace Calc
{
    public class Calculadora
    {
        public int? Soma(int? a, int? b) => (a + b);
        public int? Sub(int? a, int? b) => (a - b);
        public int? Mult(int? a, int? b) => (a * b);
        public int? Div(int? a, int? b)
        {
            if (b == 0)
            {
                Console.WriteLine("Divisor igual a 0");
                Thread.Sleep(100);
                Console.Clear();
                return null;
            }
            return (a/b);
        }
        public int? Opera()
        {
            Console.WriteLine("Escolha uma das opções abaixo: \n 1 - Adição \n 2 - Subtração\n 3 - Multiplicação\n 4 - Divisão");
            if (int.TryParse(Console.ReadLine(), out int x) && x >= 1 && x <= 4)
            {
                return x;
            }
            Console.WriteLine("Valor invalido");
            Thread.Sleep(100);
            Console.Clear();
            return null;
        }
        public int? Teste(string a)
        {
            if (int.TryParse(a, out int x))
            {
                return x;
            }
            Console.WriteLine("Valor invalido");
            Thread.Sleep(100);
            Console.Clear();
            return null;
        }
        
    }

}