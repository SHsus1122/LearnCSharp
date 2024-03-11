using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            /*int highestNum = scores[0];
            for (int i = 1; i < scores.Length; i++)
            {
                if (highestNum < scores[i])
                    highestNum = scores[i];
            }
            return highestNum;*/
            int maxValue = 0;
            foreach (int score in scores)
            {
                if (score > maxValue)
                    maxValue = score;
            }
            return maxValue;
        }

        static int GetAverageScore(int[] scores)
        {
            /*int result = 0;
            foreach (int score in scores)
                result += score;
            return result / scores.Length;*/
            // 배열이 0일 경우 0으로 나눈다는 것은 말이 안되기에 바로 0을 리턴
            if (scores.Length == 0) return 0;

            int sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }

            return sum / scores.Length;
        }

        static int GetIndexOf(int[] scores, int value)
        {
            /*for (int i = 0; i < scores.Length; i++)
                if (scores[i] == value)
                    return i;
            return -1;*/
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] == value)
                    return i;
            }
            return -1;
        }

        // 정렬
        static void Sort(int[] scores)
        {
            /*int temp = 0;
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
            }*/
            for (int i = 0; i < scores.Length; i++)
            {
                int minIndex = i;
                for (int j = i; j < scores.Length; j++)
                {
                    if (scores[j] < scores[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = scores[i];
                scores[i] = scores[minIndex];
                scores[minIndex] = temp;
            }
        }

        // 2차원 배열을 활용해서 맵을 만들어서 출력해보기
        class Map
        {
            int[,] tiles = {
                { 1, 1, 1, 1, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 1, 1, 1, 1 }
        };

            // 맵을 화면에 출력해주는 함수입니다.
            public void Render()
            {
                {
                    // ForegroundColor : 출력문 글씨 색상 변경 함수입니다.
                    // 출력이 다 끝나고 나면 색상을 원래대로 되돌리기 위해 기존의 색상을 저장하고 시작합니다.
                    var defaultColor = Console.ForegroundColor;

                    // 1차원 배열 사이즈
                    for (int y = 0; y < tiles.GetLength(1); y++)
                    {
                        // 2차원 배열 사이즈
                        for (int x = 0; x < tiles.GetLength(0); x++)
                        {
                            if (tiles[y, x] == 1)
                                Console.ForegroundColor = ConsoleColor.Red;
                            else
                                Console.ForegroundColor = ConsoleColor.Green;

                            Console.Write('\u25cf');
                        }
                        Console.WriteLine();
                    }
                    // 위에서 색 변경 및 출력이 다 끝났기 때문에 원래 색으로 되돌립니다.
                    Console.ForegroundColor = defaultColor;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] scores = new int[] { 10, 70, 40, 20, 50, 60, 35 };

            // 다차원 배열 선언, 초기화
            // [2, 3] -> 2 : 2차원 크기, 3 : 1차원 크기
            // [0, 0][0, 1][0, 2] [1, 0][1, 1][1, 2]  <- 이러한 형태
            int[,] arr = new int[2, 3];
            arr[0, 0] = 1;
            arr[1, 0] = 2;

            // 다차원 배열 선언 및 초기화 1
            int[,] arr2 = new int[2, 3] { { 1, 2, 3 }, { 1, 2, 3, } };

            // 다차원 배열 선언 및 초기화 2
            int[,] arr3 = { { 1, 2, 3 }, { 1, 2, 3, } };

            Map map = new Map();
            map.Render();

            // 배열 안의 배열을 만들기
            int[][] testMap = new int[3][];
            testMap[0] = new int[3];
            testMap[1] = new int[6];
            testMap[2] = new int[2];
        }
    }
}
