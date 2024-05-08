namespace testes;

public class UnitTest1
{
    Calculadora calc = new Calculadora();
    [Fact]
    public void Soma1Mais1Igual2()
    {
    //    Calculadora calc = new Calculadora();


        //Arrange
        var num1 = 1;
        var num2 = 1;

        //Act
        var resultado = calc.soma(num1, num2);
        
        //Assert
        Assert.Equal(2, resultado);
    }

    [Fact]
    public void Subtrai2de5Resulta3()
    {
    //    Calculadora calc = new Calculadora();

        //Arrange
        var num1 = 5;
        var num2 = 2;

        //Act
        var resultado = calc.substrair(num1, num2);

        //Assert
        Assert.Equal(3, resultado);
    }

    [Fact]
    public void Multiplica2vezes5Resulta10()
    {
    //    Calculadora calc = new Calculadora();

        //Arrange
        var num1 = 2;
        var num2 = 5;

        //Act
        var resultado = calc.multiplicar(num1, num2);

        //Assert
        Assert.Equal(10, resultado);
    }
    
    [Fact]
    public void Divide15por3Resulta5()
    {
    //    Calculadora calc = new Calculadora();

        // Arrange
        var num1 = 15;
        var num2 = 3;
    
        // Act
        var resultado = calc.dividir(num1, num2);

        // Assert
        Assert.Equal(5, resultado);
    }
}