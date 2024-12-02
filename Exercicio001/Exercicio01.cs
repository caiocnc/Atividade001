using BaseAtividades;

namespace Atividade001
{
    /// <summary>
    /// Escreva um código em C# que imprima os números de 1 a 10.
    /// </summary>
    public class Exercício01 : IBaseExercicio
    {
        public void FazerExercício()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
