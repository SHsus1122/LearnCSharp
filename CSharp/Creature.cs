using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public enum CreatureType
    {
        None,
        Player = 1,
        Monster = 2
    }

    class Creature
    {
        CreatureType type;

        protected int hp = 0;
        protected int attack = 0;

        protected Creature(CreatureType type)
        {
            this.type = type;
        }

        // 기본 정보 Setter
        public void SetInfo(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;
        }

        // 정보 관련 Getter
        public int GetHp() { return hp; }
        public int GetAttack() { return attack; }

        // 상태 관련 함수
        public bool IsDead() { return hp <= 0; }
        public void OnDamaged(int damage)
        {
            hp -= damage;
            if (hp < 0)
                hp = 0;
        }
    }
}
