using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;
    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }
    [Fact]
    public void DeveSomar10Com2ERetronar12()
    {
        // Arrange
        int num1 = 10;
        int num2 = 2;

        // Act
        int resultado = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(12, resultado);

    }

    [Fact]
    public void DeveSubtrair10De2ERetronar8()
    {
        // Arrange
        int num1 = 10;
        int num2 = 2;

        // Act
        int resultado = _calc.Subtrair(num1, num2);

        // Assert
        Assert.Equal(8, resultado);

    }

    [Fact]
    public void DeveMultiplicar10Por2ERetronar20()
    {
        // Arrange
        int num1 = 10;
        int num2 = 2;

        // Act
        int resultado = _calc.Multiplicar(num1, num2);

        // Assert
        Assert.Equal(20, resultado);

    }

    [Fact]
    public void DeveDividir10Por2ERetronar5()
    {
        // Arrange
        int num1 = 10;
        int num2 = 2;

        // Act
        int resultado = _calc.Dividir(num1, num2);

        // Assert
        Assert.Equal(5, resultado);

    }
}