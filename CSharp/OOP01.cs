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
    }

    class Knight : Player
    {

    }

    class Mage : Player
    {
        public int mp;
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

            /*
                        // Mage -> 타입 Player 타입 변환 가능
                        // Player 타입 -> Mage 타입 변환 불가능
                        Player magePlayer = mage;
                        // 하지만 (Mage) 를 사용해서 직접 명시해주면 형변환은 가능
                        // 다만, 아래 방식은 강제로 형변환 한 것이기 때문에 문제가 생길 수 있습니다.
                        Mage mage2 = (Mage)magePlayer;

                        // 즉, 자식에서 부모로 가는 것은 문제가 없습니다.
                        // 하지만, 부모에서 자식으로 가는 것은 문제가 생길 수도 있고 안 생길 수도 있습니다.(Case by Case)
            */

            EnterGame(knight);
            EnterGame(mage);
        }
    }
}
