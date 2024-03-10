using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    // 다양한 게임 모드를 위한 열거형, 여기서는 Map 에 가깝습니다.
    public enum GameMode
    {
        None,
        Lobby,
        Town,
        Field
    }

    class Game
    {
        // Setter 를 이용해서 해도 되나 지금은 우선 작동 확인을 위해서 기본 모드를 Lobby로 설정했습니다.
        private GameMode mode = GameMode.Lobby;
        private Player player = null;

        // 가장 기본이 되는 Proccess 로 시작합니다. (모드(맵) 선택 시작)
        public void Proccess()
        {
            switch (mode)
            {
                case GameMode.Lobby:
                    ProccessLobby();
                    break;
                case GameMode.Town:
                    ProccessTown();
                    break;
                case GameMode.Field:
                    ProccessField();
                    break;
            }
        }

        // 로비 시작
        public void ProccessLobby()
        {
            Console.WriteLine("직업을 선택하세요");
            Console.WriteLine("[1] 기사\n[2] 궁수\n[3] 법사");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    player = new Knight();
                    mode = GameMode.Town;
                    break;
                case "2":
                    player = new Archer();
                    mode = GameMode.Town;
                    break;
                case "3":
                    player = new Mage();
                    mode = GameMode.Town;
                    break;
            }
        }

        // 마을 진입
        private void ProccessTown()
        {
            Console.WriteLine("마을에 입장했습니다.");
            Console.WriteLine("[1] 필드로 가기\n[2] 로비로 돌아가기");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    mode = GameMode.Field;
                    break;
                case "2":
                    mode = GameMode.Lobby;
                    break;
            }
        }

        // 필드 진입
        private void ProccessField()
        {

        }

    }
}
