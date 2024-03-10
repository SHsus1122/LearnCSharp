using System;

namespace CSharp
{
	class TextRPG { 
		static void Main(string[] args)
		{
			Player player = new Knight();
			Player player2 = new Archer();
			Monster monster = new Orc();

			int damage = player.GetAttack();
			monster.OnDamaged(damage);

			player2.OnDamaged(player.GetAttack());
			
            Console.WriteLine(monster.GetHp());
            Console.WriteLine(player2.GetHp());
        }
	}
}
