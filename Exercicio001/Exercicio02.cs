using BaseAtividades;
using System.Security.Cryptography.X509Certificates;

namespace Atividade001
{
    /// <summary>
    ///  Crie uma função em C# que receba dois números e retorne a soma deles.
    /// </summary>
    public class Exercício02 : IBaseExercicio
    {
        public void FazerExercício()
        {
            /*Console.WriteLine("Escreva o 1 numero: "); 
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o 2 numero: ");
            var num2 = int.Parse(Console.ReadLine());
            int soma = num1 + num2;
            Console.WriteLine("O resultado é: {0}", soma);*/

            int num1;
            int num2;

            while (true)
            {
                Console.WriteLine("Escreva o primeiro numero: ");
                if (int.TryParse(Console.ReadLine(), out num1))
                {
                    break;
                }
                Console.WriteLine("Escreva um numero válido");
            }
            while (true)
            {
                Console.WriteLine("Escreva o segundo numero: ");
                if (int.TryParse(Console.ReadLine(), out num2))
                {
                    break;
                }
                Console.WriteLine("Escreva um numero válido");
            }


            int resultado = num1 + num2;
            Console.WriteLine($"A soma de {0} + {1} é igual a: {2}", num1, num2, resultado); 
        }
    }
}
