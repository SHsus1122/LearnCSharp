using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    // 객체지향(OOP, Object Oriented Programming)

    // Knight - 속성 : hp, attack / 기능 : Move, Attack, Die
    // 속성과 기능을 채워넣기
    // Class 의 경우 참조를 해서 값을 넘깁니다.
    class Knight
    {
        // 클래스 외부에서도 사용해주기 위해서 접근제어자 지정
        public int hp;
        public int attack;

        // 이동 기능 함수
        public void Move()
        {
            Console.WriteLine("Knight Move");
        }

        // 공격 기능 함수
        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }

        // Deep Copy 함수
        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.attack = attack;
            return knight;
        }
    }

    // Struct 의 경우 값을 복사해서 넘기게 됩니다.
    struct Mage
    {
        public int hp;
        public int attack;
    }

    internal class OOP01
    {
        static void KillMage(Mage mage)
        {
            mage.hp = 0;
        }

        static void KillKnight(Knight knight)
        {
            knight.hp = 0;
        }

        static void Main(string[] args)
        {
            Mage mage;
            mage.hp = 100;
            mage.attack = 50;
            KillMage(mage);

            Mage mage2;
            mage2.hp = 0;

            // 새로운 객체 생성
            Knight knight = new Knight();

            // 속성에 접근해서 값을 지정
            knight.hp = 100;
            knight.attack = 10;

            // 속성에 접근해서 기능을 사용
            knight.Move();
            knight.Attack();
            KillKnight(knight);

            // Deep Copy 방식인 Clone 함수를 이용한 새로운 객체 생성
            Knight knight2 = knight.Clone();
            knight2.hp = 50;
        }
    }
}
