using BaseAtividades;

namespace Atividade001
{
    /// <summary>
    /// Escreva um código em C# que verifique se um número é par.
    /// </summary>
    public class Exercício03 : IBaseExercicio
    {
        public void FazerExercício()
        {
            List<int> valores = new List<int>();
            for (int i = 0; i <= 100; i++)
            {
                valores.Add(i);
            }
            foreach (int valor in valores)
            {
                if (valor % 2 == 0)
                {
                    Console.WriteLine(valor);
                }
            }
        }
    }
}
