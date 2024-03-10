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

    class Player
    {
        protected int hp;
        protected int attack;

        public virtual void Move()
        {
            Console.WriteLine("Player 이동");
        }
    }

    // 오버로딩 - 함수 이름의 재사용(이름은 재사용하지만, 인자는 다름)
    // 오버라이딩 - 다형성 이용 여기서 처럼 virtual 과 override 키워드를 사용한 예시
    class Knight : Player
    {
        // sealed 를 붙이면 Knight 까지만 Move 함수를 상속받아서 사용이 가능합니다.
        // 즉, Knight 를 상속받은 경우 더이상 Move 함수의 사용이 불가능하게 됩니다.
        public sealed override void Move()
        {
            Console.WriteLine("Knight 이동");
        }
    }

    class Mage : Player
    {
        public int mp;

        public override void Move()
        {
            Console.WriteLine("Mage 이동");
        }
    }

    class SuperKnight : Knight
    {
        // 아래처럼 위에서 sealed 를 Move 함수에 붙여놓을 경우 그 아래의 자식에서는 사용이 불가능합니다.
        /*public override void Move()
        {
            Console.WriteLine("SuperKnight 이동");
        }*/
    }

    internal class OOP01
    {
        // "is" 키워드 사용한 형변환
        /*        static void EnterGame(Player player)
                {
                    // 그래서 이렇게 "is" 를 활용해서 한 번 검증을 거쳐주면 해결할 수 있습니다.(안전한 형변환)
                    bool isMage = (player is Mage);
                    if (isMage)
                    {
                        Mage mage = (Mage)player;
                        mage.mp = 10;
                    }
                }*/

        // "as" 키워드 사용한 형변환
        static void EnterGame(Player player)
        {
            player.Move();

            // "as" 사용시 이렇게 리턴 값을 캐스팅할 타입까지 지정 가능, 실패시 null
            Mage mage = (player as Mage);
            if (mage != null)
            {
                mage.mp = 10;
            }
        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            EnterGame(knight);
            EnterGame(mage);
        }
    }
}
