using System;
using System.Threading.Channels;

namespace CSharp // Note: actual namespace depends on the project name.
{
    class Program
    {
        // ========================================== [ 열거형 ]
        // 플레이어(유저) 타입 열거형 사용
        enum ClassType
        {
            None = 0,
            Knight = 1,
            Archer = 2,
            Mage = 3
        }

        // 몬스터 타입 열거형 사용
        enum MonsterType
        {
            None = 0,
            Slime = 1,
            Orc = 2,
            Skeleton = 3
        }



        // ========================================== [ 구조체 ]
        // 구조체 사용 플레이어 정보 생성
        struct Player
        {
            public int hp;
            public int attack;
        }

        // 구조체 사용 몬스터 정보 생성
        struct Monster
        {
            public int hp;
            public int attack;
        }



        // ========================================== [ 생성 함수 ]
        // out 키워드 사용 플레이어 정보 생성
        static void CreatePlayer(ClassType choice, out Player player)
        {
            switch (choice)
            {
                case ClassType.Knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case ClassType.Archer:
                    player.hp = 75;
                    player.attack = 12;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.attack = 15;
                    break;
                default:
                    player.hp = 0;
                    player.attack = 0;
                    break;
            }
        }

        // out 키워드 사용 몬스터 정보 생성
        static void CreateRandomMonster(out Monster monster)
        {
            Random rand = new Random();
            int randomMonster = rand.Next(1, 4);    // 1~3 사이의 숫자 랜덤
            switch (randomMonster)
            {
                case (int)MonsterType.Slime:
                    Console.WriteLine("슬라임이 스폰되었습니다!");
                    monster.hp = 20;
                    monster.attack = 2;
                    break;
                case (int)MonsterType.Orc:
                    Console.WriteLine("오크가 스폰되었습니다!");
                    monster.hp = 40;
                    monster.attack = 4;
                    break;
                case (int)MonsterType.Skeleton:
                    Console.WriteLine("스켈레톤이 스폰되었습니다!");
                    monster.hp = 30;
                    monster.attack = 3;
                    break;
                default:
                    Console.WriteLine("스폰 실패!");
                    monster.hp = 0;
                    monster.attack = 0;
                    break;
            }
        }



        // ========================================== [ 진행 함수 ]
        // 직업 고르기 함수
        static ClassType ChooseClass()
        {
            Console.WriteLine("직업을 선택하세요.");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");

            ClassType choice = ClassType.None;
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    choice = ClassType.Knight;
                    break;
                case "2":
                    choice = ClassType.Archer;
                    break;
                case "3":
                    choice = ClassType.Mage;
                    break;
            }

            return choice;
        }

        // 게임 시작
        static void EnterGame(ref Player player)
        {
            while (true)
            {
                Console.WriteLine("게임에 접속했습니다!");
                Console.WriteLine("[1] 필드로 간다");
                Console.WriteLine("[2] 로비로 돌아가기");

                string input = Console.ReadLine();
                if (input == "1")
                {
                    EnterField(ref player);
                }
                else if (input == "2")
                {
                    break;
                }
            }
        }

        // 필드 접속
        static void EnterField(ref Player player)
        {
            while (true)
            {
                Console.WriteLine("필드에 접속했습니다!");
                // 랜덤으로 1~3 몬스터 중 하나를 리스폰
                // [1] 전투 모드로 돌입
                // [2] 일정 확률로 마을로 도망

                Monster monster;
                CreateRandomMonster(out monster);

                Console.WriteLine("[1] 전투 모드로 돌입");
                Console.WriteLine("[2] 일정 확률로 마을로 도망");

                string input = Console.ReadLine();
                if (input == "1")
                {
                    Fight(ref player, ref monster);
                }
                else if (input == "2")
                {
                    // 도망갈 확률, 여기서는 33%
                    Random rand = new Random();
                    int randValue = rand.Next(0, 101);
                    if (randValue <= 33)
                    {
                        Console.WriteLine("도망치는데 성공했습니다!");
                        break;
                    }
                    else
                    {
                        Fight(ref player, ref monster);
                    }
                }
            }
        }

        // 전투 시작
        static void Fight(ref Player player, ref Monster monster)
        {
            while (true)
            {
                // 플레이어가 몬스터 공격
                monster.hp -= player.attack;
                if (monster.hp <= 0)
                {
                    Console.WriteLine("승리했습니다!");
                    Console.WriteLine($"남은 체력 : {player.hp}");
                    break;
                }
                // 몬스터 반격
                player.hp -= monster.attack;
                if (player.hp <= 0)
                {
                    Console.WriteLine("패배했습니다!");
                    break;
                }
            }
        }



        // ========================================== [ 메인 함수 ]
        static void Main2(string[] args)
        {
            while (true)
            {
                ClassType choice = ChooseClass();
                if (choice != ClassType.None)
                    continue;

                // 캐릭터 생성
                Player player;
                CreatePlayer(choice, out player);
                //Console.WriteLine($"HP : {player.hp} / attack : {player.attack}");

                EnterGame(ref player);
            }
        }
    }
}