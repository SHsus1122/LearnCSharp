using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class CSharpPractice
    {
        /*
         * 제네릭에 조건 추가하는 방법
         *  1. T 가 반드시 값 형식임을 명시
         *    class MyList<T> where T : struct
         *  2. T 가 반드시 참조 형식임을 명시
         *    class MyList<T> where T : class
         *  3. T 가 반드시 어떠한 인자도 받지 않는 기본 생성자가 존재 해야함을 명시
         *    class MyList<T> where T : new()
         *  4. T 는 반드시 몬스터 혹은 몬스터를 상속받은 클래스여야 함을 명시
         *    class MyList<T> where T : Monsters
         */

        // Generic, 일반화 형식 사용
        // 아래처럼 "<>" 제네릭 안에 T 라는 이름으로 템플릿 혹은 타입의 약자로 많이 사용합니다.
        // 즉, T 는 일반적으로 많이 사용한다는 거지 무엇을 쓸지는 자유입니다.
        class MyList<T>
        {
            T[] arr = new T[10];

            public T GetItem(int i)
            {
                return arr[i];
            }
        }

        class Monsters
        {

        }

        // static 을 사용한 경우에도 이렇게 제네릭을 사용할 수 있습니다.
        static void Test<T>(T input)
        {

        }

        static void Main(string[] args)
        {
            // Generic 활용법
            // 아래 처럼 <T> 안에 int, float, Monsters 등 어떠한 것을 넣어도 치환되어서 정상 작동 합니다.
            MyList<int> myIntList = new MyList<int>();
            int item = myIntList.GetItem(0);

            MyList<short> myShortList = new MyList<short>();
            MyList<float> myFloatList = new MyList<float>();
            MyList<Monsters> myMonsterList = new MyList<Monsters>();

            Test<int>(3);
            Test<float>(5.5f);
        }
    }
}
