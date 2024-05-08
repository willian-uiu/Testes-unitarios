using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testes
{
    public class Calculadora
    {
        public int soma(int num1, int num2)
        {
            return num1 + num2;
        }

        public int substrair(int num1, int num2)
        {
            return num1 - num2;
        }

        public int multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int dividir(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}