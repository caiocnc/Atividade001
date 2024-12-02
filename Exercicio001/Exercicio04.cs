using BaseAtividades;

namespace Atividade001
{
    /// <summary>
    /// Crie um programa em C# que calcule a área de um círculo dado o raio.
    /// </summary>
    public class Exercício04 : IBaseExercicio
    {
        public void FazerExercício()
        {
            double raio;
            while (true)
            {
                Console.WriteLine("Escreva o valor do raio: ");
                if (double.TryParse(Console.ReadLine(), out raio))
                {
                    break;
                }
                Console.WriteLine("Escreva um numero válido");
            }

            double resultado = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine($"A área do círculo, dado o raio no valor de {raio} é igual a: {resultado}");
        }
    }
}

