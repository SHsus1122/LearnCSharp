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

    // 자동차를 탄다고 가정 합니다.
    // 핸들, 폐달, 차문 같은 외부로 노출되는 기능이 있고
    // 전기장치, 엔진 같은 외부로 노출되지 않는 기능이 있다고 합니다.
    //  여기서 은닉성은 위의 기능들 중 노출되면 않되는 중요 기능들을 숨기는 것들을 말합니다.

    class Knight
    {
        // 접근 제어자(제한 레벨) public, protected, private
        //  - pulic     : 모든 곳에서 사용 가능
        //  - private   : 본인 클래스 내에서만 사용 가능
        //  - protected : 자식에서만 접근 가능
        private int hp;
        public int mp;
        protected int ap;
        
        // 외부에서 접근 불가
        public void SetHp(int hp)
        {
            this.hp = hp;
        }

        public int GetHp()
        {
            return this.hp;
        }
    }

    class SuperKnight : Knight
    {
        // private 레벨인 hp 는 에러 발생
        public void SetMp()
        {
            this.hp = 150;
        }

        // protected 레벨인 ap 는 정상 작동
        public void SetAp()
        {
            this.ap = 50;
        }
    }

    internal class OOP01
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();

            // private 레벨인 hp 와 protected 인 ap 는 직접 접근 불가능, 에러 발생
            knight.hp = 100;
            knight.ap = 100;
            // 하지만, public 의 경우 이렇게 직접 접근이 가능
            knight.mp = 100;

            // 하지만 아래처럼 Getter, Setter 를 활용한 내부 함수로는 가능
            knight.SetHp(100);                  // 100 으로 설정
            Console.WriteLine(knight.GetHp());  // 결과 : 100

            SuperKnight superKnight = new SuperKnight();
            // protected 레벨인 ap 는 자식에서 접근 가능하나 이는 어디까지나 상속받은 클래스 내에서 가능
            // 이렇게 직접 접근은 불가능, 그래서 Getter, Setter 라는 함수(개념)가 필요합니다.
            superKnight.ap = 100;
        }
    }
}
