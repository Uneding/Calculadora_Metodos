using Calc;
Calculadora cal = new Calculadora();
int? processo = null;
do
{
    processo = cal.Opera();
}
while (processo == null);
int? a, b;
do
{
    Console.WriteLine("Entre com o primeiro valor:");
    a = cal.Teste(Console.ReadLine());
}
while (a == null);
do
{
    Console.WriteLine("Entre com o segundo valor:");
    b = cal.Teste(Console.ReadLine());
}
while (b == null);
switch (processo)
{
    case 1:
        Console.WriteLine(cal.Soma(a, b));
        break;
    case 2:
        Console.WriteLine(cal.Sub(a, b));
        break;
    case 3:
        Console.WriteLine(cal.Mult(a, b));
        break;
    case 4:
        do
        {
            a = cal.Div(a, b);
        }
        while (a == null);
        Console.WriteLine(a);
        break;
}
Console.ReadKey();
Console.Clear();