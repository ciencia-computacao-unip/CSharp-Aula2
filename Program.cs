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

            Console.Write("\n\n\n");

            //Exercício 2
            Console.WriteLine("2) Faça um programa que peça para o usuário digitar o nome, idade, altura e peso. Ao final exiba todas as informações lidas.");
            string nome;
            int idade;
            double altura, peso;
            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite sua altura (em cm): ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o seu peso (em kg): ");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n\nSeu nome é " + nome + ".");
            Console.WriteLine("Sua idade é " + idade + " anos.");
            Console.WriteLine("Você tem " + altura + "cm de altura.");
            Console.WriteLine("Seu peso é de " + peso + "kg.");
            //fim doexercício 2
        }
    }
}
