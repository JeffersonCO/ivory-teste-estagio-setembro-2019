using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_1
{
    class Program
    {
      //Função recursiva para calcular um numero fatorial.
        public int Calcular(int numero)
        {
            int resultado;
            //Como parametro de parada da função foi colocado que o numero seja zero
            //porem se for esse o caso a função vai sempre retornar 0 pois segundo as leis matematicas 
            //todo numero multiplicado por zero e zero, sendo assim o menor numero possivel para retorno de uma 
            //função fatorial seria o numero 1.
            if (numero <= 1)
            {
                return (1);
            }
            //Cjamada da função formando uma pilha de operações a serem executadas apos a parada da função.
            else
            {
                resultado = numero * (Calcular(numero - 1));
                return resultado;
            }
        }
        public void Main()
        {//Metodo  para chamar a função e apresentar o resultado a partir de um numero pré estabelecido .
            int numero = 5;
            int resultado = Calcular(numero);

            Console.WriteLine("Resultado :{0}", resultado);
            Console.ReadKey();
        }

    }
}
 
        
    
    


