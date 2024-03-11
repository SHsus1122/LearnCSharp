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
        // 프로퍼티, Property
        // 이를 위해서 객체지향의 은닉성에 대해서 다시 짚고 넘어갑니다.

        class Knights
        {
            // 프로퍼티 선언
            // 1. 일반적인 방법
            /*protected int hp;

            public int Hp
            {
                // value 는 default 명 입니다.
                get { return hp; }
                private set { hp = value; }
            }*/

            // 2. 자동 구현 프로퍼티 방법
            public int Hp { get; set; } = 100;  // C# 7.0 부터 지원하는 바로 초기화 하는 문법(= 100;)

            private int hp;
            public int GetHp() { return hp; }
            public void SetHp(int value) { hp = value; } 
        }

        static void Main(string[] args)
        {
            Knights knights = new Knights();

            // 프로퍼티 사용
            knights.Hp = 100;
            int hp = knights.Hp;
        }
    }
}
