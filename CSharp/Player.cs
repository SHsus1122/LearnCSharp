using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    // Player 의 Type 을 분류하기 위한 열거형
    public enum PlayerType
    {
        None = 0,
        Knight = 1,
        Archer = 2,
        Mage = 3
    }

    class Player : Creature
    {
        // 기본 플레이어 속성을 가질 멤버변수, 초기화 작업
        protected PlayerType type = PlayerType.None;

        // 생성자 커스텀
        protected Player(PlayerType type) : base(CreatureType.Player)
        {
            this.type = type;
        }

        public PlayerType GetPlayerType() { return type; }
    }

    // Player 자식 클래스들
    class Knight : Player
    {
        public Knight() : base(PlayerType.Knight)
        {
            SetInfo(100, 10);
        }
    }

    class Archer : Player
    {
        public Archer() : base(PlayerType.Archer)
        {
            SetInfo(75, 12);
        }
    }

    class Mage : Player
    {
        public Mage() : base(PlayerType.Mage)
        {
            SetInfo(50, 20);
        }
    }

}
