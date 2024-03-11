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
        // 추상 클래스, abstract
        abstract class Monsters
        {
            public abstract void Shout();
        }

        // 인터페이스 사용
        interface IFlyable
        {
            // 이 IFlyable 를 가진 인터페이스 에서는 Fly 라는 함수(기능)을 반드시 구현해야 합니다.
            // 하지만 abstract 를 사용한 것과 달리 어떠한 형태로 구현할지는 강제하지 않습니다.
            void Fly();
        }

        class Orc : Monsters
        {
            public override void Shout()
            {
                Console.WriteLine("록타르 오가르!");
            }
        }

        class Skeletons : Monsters
        {
            public override void Shout()
            {
                Console.WriteLine("꾸에에에엑!");
            }
        }

        // Fly 기능을 반드시(기본적으로) 내포하고 있는 FlyableOrc 클래스
        class FlyableOrc : Orc, IFlyable
        {
            public void Fly()
            {

            }
        }

        static void DoFly(IFlyable flyable)
        {
            // IFlyable 를 내포하고 있는 녀석은 DoFly 의 호출이 가능합니다 !

            // 또한 이렇게 IFlyable 이 Fly 변수를 가지고 있기 때문에 이렇게 호출도 가능합니다 !
            flyable.Fly();
        }

        static void Main(string[] args)
        {
            // 인터페이스 변수인 flyable 변수에 FlyableOrc 를 저장하는 것도 가능합니다.
            // 역으로 하는 행우지만, 이런것이 인터페이스를 사용했을 때 가능합니다.
            IFlyable flyable = new FlyableOrc();
            DoFly(flyable);     // 인자로 전달이 가능함 !! 이런식으로 사용이 가능합니다.

            // 당연히 이렇게 오크 자체를(FlyableOrc) 사용해서도 가능합니다. 
            FlyableOrc orc = new FlyableOrc();
            DoFly(orc);
        }
    }
}
