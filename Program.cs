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

            Console.Write("\n\n\n");

            //Exercício 3
            Console.WriteLine("3) Faça um programa leia dois números inteiros e exiba todos os resultados das operações aritméticas entre eles.");
            int primeiro_numero, segundo_numero;
            Console.Write("Digite o primeiro número: ");
            primeiro_numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            segundo_numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nA soma dos dois números é "+(primeiro_numero+segundo_numero));
            Console.WriteLine("A subtração é " + (primeiro_numero - segundo_numero));
            Console.WriteLine("A multiplicação é " + (primeiro_numero * segundo_numero));
            Console.WriteLine("A divisão é " + (Convert.ToDouble(primeiro_numero) / Convert.ToDouble(segundo_numero)));
            //fim do exercício 3

            Console.Write("\n\n\n");

            //Exercício 4
            Console.WriteLine("4) Escreva um programa que leia uma palavra e ao final exiba a quantidade de caracteres existentes nesta palavra.");
            String palavra;
            Console.Write("Digite uma palavra: ");
            palavra = Console.ReadLine();
            Console.WriteLine("A palavra que você digitou contém " + palavra.Length + " caracteres.");
            //fim do exercício 4

            Console.Write("\n\n\n");
            
            //Exercício 5
            Console.WriteLine("5) Escreva um programa que calcule o estoque médio de um produto, usando a fórmula:");
            Console.WriteLine("Estoque Médio = (Quantidade Mínima + Quantidade Máxima) / 2");
            int quantidade_minima, quantidade_maxima;
            Console.WriteLine("Calculo de estoque médio de Paçoca");
            Console.Write("Digite a quantidade mínima de paçoca: ");
            quantidade_minima = Convert.ToInt32(Console.ReadLine());
            Console.Write("Agora digite a quantidade máxima de paçoca: ");
            quantidade_maxima = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O estoque médio de paçoca é " + ((quantidade_minima + quantidade_maxima) / 2));
            //fim do exercício 5

            Console.ReadKey();
        }
    }
}
