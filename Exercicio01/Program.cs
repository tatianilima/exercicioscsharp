using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa para ler dois valores inteiros,
             *e depois mostrar na tela a soma desses números com uma mensagem explicativa,
             *conforme exemplos.
             */
            //Primeiro declarar as variaveis
            int valor1, valor2, soma;

			//Depois exibir a janela de entrada de dados
			Console.WriteLine("Informe o valor 1:");
			valor1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Informe o valor 2:");
			valor2 = int.Parse(Console.ReadLine());

			soma = valor1 + valor2;
            Console.WriteLine("Resultado:");
            Console.WriteLine(soma); 
		} 
    }
}
