using System;
using System.Collections.Generic;
using System.Text;

namespace MatchSumGoogle
{
    public class Starter
    {
        public Starter()
        {
            Start(10);
            NaoOrdenada();
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

        private bool Start(int sum)
        {
            var vetor = GerarListaNaoOrdenada();

            Array.Sort(vetor);
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
                    continue;
                }
                else if ((vetor[MIN] + vetor[MAX]) < sum)
                {
                    MIN += 1;
                    continue;
                }
                return true;
            }
            return false;

        }

        private bool NaoOrdenada()
        {
            var vetor = GerarListaNaoOrdenada();
            return false;
        }
    }
}
