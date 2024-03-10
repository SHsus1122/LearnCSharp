using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    // 객체지향(OOP, Object Oriented Programming)
    // - 은닉성, 상속성, 다형성

    class Player    // 부모 클래스 혹인 기반 클래스
    {
        static public int counter;  // 오로지 1 개만 존재합니다.
        public int id;              // 플레이어 고유 아이디
        public int hp;
        public int attack;

        public Player()
        {
            Console.WriteLine("Player 생성자 호출!");
        }

        public Player(int hp)
        {
            this.hp = hp;
            Console.WriteLine("Player [HP] 생성자 호출!");
        }

        public Player(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;
            Console.WriteLine("Player [HP, Attack] 생성자 호출!");
        }
    }

    class Mage : Player // 자식 클래스 혹은 파생 클래스
    {
        
    }

    class Archer : Player
    {
        
    }

    // Knight - 속성 : hp, attack / 기능 : Move, Attack, Die
    // 속성과 기능을 채워넣기
    // Class 의 경우 참조를 해서 값을 넘깁니다.
    class Knight : Player
    {
        int myHp;
        // 생성자
        public Knight() : base(100, 10) // 부모의 멤버 선택 키워드 "base"
        {
            id = counter;
            counter++;

            hp = 100;
            attack = 10;

            this.myHp = 10; // 자식의 멤버 변수 접근
            base.hp = hp;   // 부모의 멤버 변수 접근

            Console.WriteLine("Knight 생성자 호출!");
        }

        // Knight 생성용 정적 함수
        static public Knight CreateKnight()
        {
            Knight Knight = new Knight();
            Knight.hp = 100;
            Knight.attack = 10;
            return Knight;
        }

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

    internal class OOP01
    {
        static void Main(string[] args)
        {
            // 새로운 객체 생성(기존 방법)
            Knight knight = new Knight();

            // 새로운 객체 생성(static 활용)
            Knight knight2 = Knight.CreateKnight();
        }
    }
}
