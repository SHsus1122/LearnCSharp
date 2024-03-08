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
    }

    internal class OOP01
    {
        static void Main(string[] args)
        {
            // 새로운 객체 생성
            Knight knight = new Knight();

            // 속성에 접근해서 값을 지정
            knight.hp = 100;
            knight.attack = 10;

            // 속성에 접근해서 기능을 사용
            knight.Move();
        }
    }
}
