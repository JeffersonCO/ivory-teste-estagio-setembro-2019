using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_2
{
    class Program
    {

        static void Main(string[] args)
        {
            
            //Declarando as variaveis .
            string name;
            string[,] matriz;
            char[] splitName = new char[1];
            Console.BackgroundColor = ConsoleColor.Red;
            //Entrada do programa, Digitar o nome a ser inserido na Matriz.
            Console.WriteLine("Escreva o nome a ser inserido na matriz: ");
            Console.WriteLine();
          
            //Convertendo a string em um array de caracter.
            Console.ForegroundColor = ConsoleColor.White;
            name = Console.ReadLine();
            Console.WriteLine();
            splitName = name.ToCharArray();
            matriz = new string[3, name.Length + 3];
            int n1 = 0;

            //Criação da implementação na Matriz
            //È necessario criar linha por linha da matriz
            //Eixo horizontal ou linha  da Matriz .
            for (int i = 0; i < 3; i++)
            {
                //Eixo vertical ou coluna da Matriz .
                for (int k = 0; k < name.Length * 3; k++)
                {
                    //Atribuindo Valores dentro dos campos da Matriz na primeira Linha.
                    if (i < 1 && k < name.Length + 2)
                    {
                        n1++;
                        string n2 = Convert.ToString(n1);
                        Console.Write(matriz[i, k] = n2 + "\t");
                    }
                    //Passando para proxima linha.
                    else if (i < 1 && k == name.Length + 2)
                    {
                        Console.WriteLine();
                    }

                    //Colocando valor na primeira posição e segunda linha da matriz.
                    if (i == 1 && k < 2)
                    {
                        int n3 = n1;
                        n3 = (name.Length + 2) * 2 + 2;
                        string n2 = Convert.ToString(n3);
                        Console.Write(matriz[i, k] = n2 + "\t");
                    }

                    //Atribuindo Valores na Segunda linha da Matriz.
                    if (i == 1 && k < name.Length - 1)
                    {
                        n1++;
                        string n2 = Convert.ToString(n1);
                        int a = -1;

                        //Atribuindo o Nome escolhido na Matriz.
                        while (a < name.Length - 1)
                        {
                            a++;
                            Console.Write(splitName[a].ToString() + "\t");
                        }

                        //Atribuindo o Valor na Ultima coluna da Segunda linha.
                        if (i == 1)
                        {
                            n2 = Convert.ToString(n1);
                            Console.Write(matriz[i, k] = n2);
                        }

                        //Atribundo Valores da Ultima linha da Matriz.
                        Console.WriteLine();
                        int n4 = (name.Length + 2) * 2 + 2;

                        for (int y = 0; y < name.Length + 2; y++)
                        {
                            n4--;
                            n2 = Convert.ToString(n4);
                            Console.Write(matriz[i, k] = n2 + "\t");
                        }
                        break;
                    }
                }
            }
            
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
