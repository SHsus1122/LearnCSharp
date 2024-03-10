using System;

namespace CSharp
{
	class TextRPG { 
		static void Main(string[] args)
		{
			// 게임 시작을 위한 새로운 게임 객체(인스턴스) 생성
			Game game = new Game();

			// 계속해서 진행되어야 하기 때문에 while 문을 이용
			while (true)
			{
				// 게임 시작에 해당하는 Prccess 함수 호출
				game.Proccess();
            }
        }
	}
}
