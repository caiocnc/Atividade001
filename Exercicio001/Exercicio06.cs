using BaseAtividades;

namespace Atividade001
{
    /// <summary>
    /// Escreva um método em C# que receba um Array de inteiros e retorne o índice do menor número. 
    /// Caso haja mais de um número menor, retorne o índice da última ocorrência.
    /// </summary>
    public class Exercício06 : IBaseExercicio
    {
        public void FazerExercício()
        {
            //Array com os numeros
            int[] numerosInt = { 2, 42, 2, 5, 1101, 2 };
            //Método para encontrar o indice onde se encontra o menor numero
            static int EncontrarIndiceDoMenorNumero(int[] arrayNum)
            {
                //Verifica se o valor é Nulo ou se o array está vazio
                if (arrayNum == null || arrayNum.Length == 0) 
                {
                    throw new ArgumentException("O array não pode ser nulo ou vazio.");
                }
                int indiceMenor = 0;
                int menorNumero = arrayNum[0];
                //Verifica os valores dentro do Array e se o valor do indice for menor que o menor numero declarado dentro do indiceMenor, ele armazena o numero no indiceMenor.
                for (int i = 1; i < arrayNum.Length; i++)
                {
                    if (arrayNum[i] <= menorNumero)
                    {
                        menorNumero = arrayNum[i];
                        indiceMenor = i;
                    }
                }
                return indiceMenor;
            }
            int indiceMenor = EncontrarIndiceDoMenorNumero(numerosInt);
            Console.WriteLine($"O indice do menor número é:{indiceMenor}");
        }
    }
}

