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
        // 대리자, Delegate
        // 우리가 어떤 업체의 사장님에게 전화하려면 이 사장님의 비서에게 연락을 하게 됩니다.
        // 이를 위해서 연락처/용건 이 필요하며 거꾸로 연락을 달라고 요청을 하게 됩니다.(콜백)

        // delegate 가 붙었으면 함수 자체를 인자로 넘겨주는 형식의 함수
        // 반환 : int , 입력 : void
        // OnClicked 이 delegate 형식의 이름이라고 보면 됩니다.
        delegate int OnClicked();

        static void ButtonPressed(OnClicked clickedFunction)
        {
            // 함수를 호출();
            clickedFunction();
        }

        static int TestDelegate()
        {
            Console.WriteLine("Hello Delegate");
            return 0;
        }

        static int TestDelegate2()
        {
            Console.WriteLine("Hello Delegate 2");
            return 0;
        }

        static void Main(string[] args)
        {
            // 가장 간단한 사용법
            // ButtonPressed(TestDelegate);

            // 원래는 내부적으로는 아래의 방식으로 동작합니다.
            // 또한, 이는 C++ 의 함수 포인터와 굉장히 비슷합니다.
            //  1. delegate 형식으로 OnClicked 타입의 새로운 객체를 만듭니다.
            //  2. 이 clicked 에는 호출 할 콜백 함수인 TestDelegate 를 인자로 전달합니다.
            //  3. 이후 clicked(); 이런식으로 바로 여기서 호출하는 것도 가능하며,
            //  4. 맨 아래처럼 ButtonPressed(clicked); 이런식으로 넘겨주는 것도 가능합니다.
            OnClicked clicked = new OnClicked(TestDelegate);
            clicked();

            ButtonPressed(clicked);

            Console.WriteLine();

            // 위처럼 ButtonPressed(TestDelegate); 이렇게가 아닌 더 어렵게 하는 이유가 있습니다.
            // 이는 Delegate 를 체이닝 하는 방법이 있기 때문입니다.
            // 여기서 말하는 것은 이 Delegate 객체에 여러개의 함수를 넘기는 것을 말합니다.
            // += 를 사용해서 이렇게 Delegate 객체에 일어나야 할 일들을 쭉 체이닝을 해서 뒤에 덧붙일 수 있습니다.
            clicked += TestDelegate2;
            ButtonPressed(clicked);
        }
    }
}
