using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAula2{
    class Program{
        static void Main(string[] args){
            //Exercício 1
            Console.WriteLine("1) Faça um programa que informe ao usuário que deverá digitar um número e o programa deverá exibir o resultado do cálculo do quadrado deste número.");
            int numero;
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O quadrado do número é " + numero * numero);
            //fim do exercício 1
        }
    }
}
