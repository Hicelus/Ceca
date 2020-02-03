using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceca
{
    class FiveOperations
    {
        private double valor1, valor2, result;
        private int operation;

        public FiveOperations(double valor1, double valor2, int operation)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
            this.operation = operation;
        }

        public double efetuarCalculo()
        {
            switch (operation)
            {
                case 1:
                    result = valor1 + valor2;
                    break;
                case 2:
                    result = valor1 - valor2;
                    break;
                case 3:
                    result = valor1 * valor2;
                    break;
                case 4:
                    result = valor1 / valor2;
                    break;
                case 5:
                    result = valor1 % valor2;
                    break;
            }

            return result;
        }
    }
}
