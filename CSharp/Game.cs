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
        private Monster monster = null;
        private Random rand = new Random();

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
            Console.WriteLine("필드에 입장했습니다.");
            Console.WriteLine("[1] 전투 시작\n[2] 일정 확률로 도망가기");

            CreateRandomMonster();

            string input = Console.ReadLine();
            switch (input) 
            { 
                case "1":
                    ProccessFight();
                    break;
                case "2":
                    TryEscape();
                    break;
            }
        }

        // 전투 함수
        private void ProccessFight()
        {
            while (true)
            {
                int damage = player.GetAttack();
                monster.OnDamaged(damage);
                if (monster.IsDead())
                {
                    Console.WriteLine("승리했습니다");
                    Console.WriteLine($"현재 HP : {player.GetHp()}");
                    break;
                }

                damage = monster.GetAttack();
                player.OnDamaged(damage);
                if (player.IsDead())
                {
                    Console.WriteLine("패배했습니다");
                    mode = GameMode.Lobby;
                    break;
                }
            }
        }

        // 도주 함수
        private void TryEscape()
        {
            int randValue = rand.Next(0, 101);
            if (randValue < 33)
            {
                mode = GameMode.Town;
            }
            else
            {
                ProccessFight();
            }
        }

        // 몬스터 랜덤 생성
        private void CreateRandomMonster()
        {
            int randValue = rand.Next(0, 3);    // 0 ~ 2 랜덤
            switch (randValue)
            {
                case 0:
                    monster = new Slime();
                    Console.WriteLine("슬라임 출현!");
                    break;
                case 1:
                    monster = new Orc();
                    Console.WriteLine("오크 출현!");
                    break;
                case 2:
                    monster = new Skeleton();
                    Console.WriteLine("해골 병사 출현!");
                    break;
            }
        }
    }
}
