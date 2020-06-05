using System;

namespace MatchSumGoogle
{
	public class Starter
	{
		public Starter()
		{
			// Verifica se a soma de nois numeros no array sao X
			Start(10);
		}

		private int[] GerarListaNaoOrdenada()
		{
			int positions = 5;
			int[] vetor = new int[positions];

			Random r = new Random();
			for (int i = 0; i < positions; i++)
			{
				vetor[i] = r.Next(1, 10);
			}
			return vetor;
		}

		private void Start(int sum)
		{
			var vetor = GerarListaNaoOrdenada();

			Array.Sort(vetor); // Teste com array ordenado
			foreach (var value in vetor)
			{
				Console.WriteLine(value);
			}

			int MAX = vetor.Length - 1;
			int MIN = 0;

			for (int i = 0; i < vetor.Length; i++)
			{
				Console.WriteLine(vetor[MIN].ToString() + " + " + vetor[MAX].ToString() + " = " + (vetor[MIN] + vetor[MAX]));
				Console.WriteLine();

				if ((vetor[MIN] + vetor[MAX]) > sum)
				{
					MAX -= 1;
				}
				else if ((vetor[MIN] + vetor[MAX]) < sum)
				{
					MIN += 1;
				}


			}
		}
	}
}
