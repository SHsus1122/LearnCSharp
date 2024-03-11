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
        static void Main(string[] args)
        {
            // List, 이는 배열과 함께 가장 많이 사용되는 자료구조 중 하나입니다.
            // 배열과는 다르게 동적으로 크기가 조절 가능하면서 동시에 index 를 사용해 요소에 접근이 가능합니다.
            // List 또한, 마찬가지로 클래스로 참조 타입 입니다.

            // 빈 List 선언
            List<int> list = new List<int>();

            for (int i = 0; i < 5; i++)
                list.Add(i);    // List 에 추가

            // 삽입 삭제
            list.Insert(2, 999);

            // (값으로 접근) Remove 의 경우 숫자 3 이 여러개일 경우 처음 것만 삭제하고 끝납니다. 반환값은 bool
            bool success = list.Remove(3);

            // (index로 접근)
            list.RemoveAt(0);

            // 모든 값 초기화
            //list.Clear();

            // list.Count -> 리스트 사이즈
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]); // index 로 접근

            foreach (int num in list)
                Console.WriteLine(num); 
        }
    }
}
