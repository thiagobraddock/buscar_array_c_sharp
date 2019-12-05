using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //vetor de 10 posicoes
            int[] numeros = new int[10];
            int search;

            //10 entradas de dados
            for(int i=0; i<10; i++)
            {
                Console.Write("Digite o {0}º valor: ", (i+1));
                numeros[i] = int.Parse(Console.ReadLine());
            }

            //search
            Console.WriteLine("\n\n");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Agora, digite um nº para pesquisar: ");
            search = int.Parse(Console.ReadLine());

            //contador de repetições
            int contador = 0;
            
            //realiza a busca dentro do array
            for(int busca = 0; busca <10; busca++)
            {
                if(numeros[busca] == search)
                {
                    contador++;
                }
            }

            //verifica se houve ou nao repetição
            if(contador > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n\nO nº {0} apareceu {1} vezes.", search, contador);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\nO nº {0} não apareceu nenhuma vez.", search, contador);
            }
            Console.ReadKey();
        }
    }
}
