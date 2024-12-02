using BaseAtividades;

namespace Atividade001
{
    /// <summary>
    /// Escreva um código em C# que encontre o maior número entre dois números.
    /// </summary>
    public class Exercício05 : IBaseExercicio
    {
        public void FazerExercício()
        {
            int num1, num2;                    
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
            string resultadoValorMax = "O maior valor entre {0} e {1} seria {2}.";
            Console.WriteLine(resultadoValorMax, num1, num2, Math.Max(num1, num2));
        }
    }
}
