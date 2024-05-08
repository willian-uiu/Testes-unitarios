// See https://aka.ms/new-console-template for more information
using Microsoft.VisualStudio.TestPlatform.Utilities;
using testes;

Calculadora calc = new Calculadora();

int valor1 = 10;
int valor2 = 5;

Console.WriteLine(calc.soma(valor1, valor2));