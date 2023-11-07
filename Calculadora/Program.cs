using Calculadora.Services;
CalculadoraImp c = new CalculadoraImp();

int num1 = 10;
int num2 = 2;

// Mostrar o resultado da Adição

Console.WriteLine($"{num1}+{num2}={c.Somar(num1, num2)}");

// Mostrar o resultado da Subtração

Console.WriteLine($"{num1}-{num2}={c.Subtrair(num1, num2)}");

// Mostrar o resultado da Multiplicação

Console.WriteLine($"{num1}*{num2}={c.Multiplicar(num1, num2)}");

// Mostrar o resultado da Divisão

Console.WriteLine($"{num1}/{num2}={c.Dividir(num1, num2)}");






