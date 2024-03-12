using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    // 사용자가 키보드나 마우스 입력을 하는것을 캐치해서 다른 곳에 알려주는
    // 즉, 중간 연결 역할을 하는 클래스입니다.
    // 아래와 같은 방식을 [Observer Pattern] 이라고 합니다.
    class InputManager
    {
        // 이벤트가 호출될 때 실행될 메서드의 형식을 정의
        public delegate void OnInputKey();

        // 이벤트 선언(이벤트 명이 InputKey)
        public event OnInputKey InputKey;

        public void Update()
        {
            // 이는 입력 버퍼에 새로운 키 입력이 없다는 것으로
            // 즉, 사용자가 새로운 키를 누르지 않았거나 입력 버퍼에 입력이 없는 상태를 의미합니다.
            if (Console.KeyAvailable == false)
                return;

            // 입력키를 가져와서 사용자가 A 키를 눌럿을 때 이후의 작업입니다.
            ConsoleKeyInfo info = Console.ReadKey();
            if (info.Key == ConsoleKey.A)
            {
                // 모두한테 알려줍니다.
                InputKey();
            }
        }
    }
}
