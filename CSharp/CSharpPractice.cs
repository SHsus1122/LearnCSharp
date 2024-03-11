using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class CSharpPractice
    {
        // 배열 연습 문제
        // 배열은 0 ~ 100 까지의 숫자를 가짐, 빈 배열은 0 을 리턴
        static int GetHighestScore(int[] scores)
        {
            int highestNum = scores[0];
            for (int i = 1; i < scores.Length; i++)
            {
                if (highestNum < scores[i])
                    highestNum = scores[i];
            }
            return highestNum;
        }

        static int GetAverageScore(int[] scores)
        {
            int result = 0;
            foreach (int score in scores)
                result += score;
            return result / scores.Length;
        }

        static int GetIndexOf(int[] scores, int value)
        {
            for (int i = 0; i < scores.Length; i++)
                if (scores[i] == value)
                    return i;
            return -1;
        }

        static void Sort(int[] scores)
        {
            int temp = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if (i + 1 < scores.Length && scores[i] > scores[i + 1])
                {
                    temp = scores[i];
                    scores[i] = scores[i + 1];
                    scores[i + 1] = temp;
                    for (int j = i; 0 < j; j--)
                    {
                        if (scores[j] < scores[j - 1])
                        {
                            temp = scores[j];
                            scores[j] = scores[j - 1];
                            scores[j - 1] = temp;
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] scores = new int[] { 100, 70, 40, 20, 50, 60, 35 };
            Console.WriteLine(GetHighestScore(scores));
            Console.WriteLine(GetAverageScore(scores));
            Console.WriteLine(GetIndexOf(scores, 50));
            Sort(scores);
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
        }
    }
}
