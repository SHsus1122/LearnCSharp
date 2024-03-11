using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class CSharpPractice
    {
        static void Main(string[] args)
        {
            // 자료구조
            // 배열, Array
            /*
                이는 동일한 데이터 형식의 여러 요소를 저장하는 데이터 구조(묶음) 입니다.
                배열은 메모리에 연속적으로 할당되며, 각 요소에는 인덱스를 사용해 접근합니다.
                고정된 크기를 가지기에 한 번 설정되면 배열의 사이즈를 변경할 수 없습니다.
             */

            //int[] scores = new int[5];   // int 타입, 5의 고정된 사이즈 배열, 빈 배열 선언

            // 0 1 2 3 4
            //scores[0] = 10;
            //scores[1] = 20;
            //scores[2] = 30;
            //scores[3] = 40;
            //scores[4] = 50;

            // new int[5] 이 안에 5 사이즈를 지정 안해도 무방
            // 또한 아래의 방식은 값의 복사가 아닌 참조 타입입니다
            int[] scores = new int[] { 10, 20, 30, 40, 50 };   // 배열 선언과 함께 초기화
            int[] scores2 = { 10, 20, 30, 40, 50 };            // 이렇게 선언도 가능합니다

            int[] scores3 = scores; // 참조타입이기 때문에 이렇게 대입이 가능합니다.
            scores3[0] = 5555;

            // 일반 for 문
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }

            // foreach 문
            // scores 안의 값들을 하나씩 뽑아서 score 에 대입
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
        }
    }
}
