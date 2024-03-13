using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    enum ItemType
    {
        Weapon,
        Armor,
        Amulet,
        Ring
    }

    // 등급 레벨
    enum Rarity
    {
        Normal,
        Uncommon,
        Rare
    }

    class Item
    {
        public ItemType ItemType;
        public Rarity Rarity;
    }

    class CSharpPractice
    {
        // Lambda : 일회용 함수를 만드는 데 사용하는 문법입니다.
        static List<Item> _items = new List<Item>();

        // 좀 더 중의적인 이름인 MyFunc
        // 이 Delegate 하나로 이제 입력 형식(T) 하나와 반환 형식(Return)이 하나가 있는 타입의 델리 게이트의 경우
        // 이 MyFunc Delegate 하나로 모두 사용이 가능해집니다.
        delegate bool Func<T, Return>(T item);

        // 위 함수와 달리 맨 처음에는 delegate bool ItemSelector(Item item); 이 함수 였습니다.
        // 즉, ItemSelector 이름에 맞게 해당 용도로만 사용하는 형태의 델리게이트였습니다.

        // 그런데 위의 MyFunc의 경우 인자를 하나 밖에 못 받는 문제가 있습니다.
        // 이런 경우 이제 아래처럼 인자 개수만큼 준비해서 함수들을 사전에 작성해두면 됩니다.

        // 반환 형식은 있고 입력 형식은 없는 경우 
        delegate bool MyFunc<Return>();
        // 입력은 두 개를 받고 반환은 하나를 받는 경우
        delegate bool MyFunc<T1, T2, Return>(T1 t1, T2 t2);

        // Weapon 검증 및 반환 함수
        /*static bool IsWeapon(Item item)
        {
            return item.ItemType == ItemType.Weapon;
        }*/

        // 직접 만든 MyFunc Delegate 를 활용한 FindItem 함수
        /*static Item FindItem(MyFunc<Item, bool> selector)
        {
            foreach (Item item in _items)
            {
                if (selector(item))
                {
                    return item;
                }
            }
            return null;
        }*/

        // 이미 C#에 만들어져 있는 Func 를 활용한 FindItem 함수
        static Item FindItem(Func<Item, bool> selector)
        {
            foreach (Item item in _items)
            {
                if (selector(item))
                {
                    return item;
                }
            }
            return null;
        }

        static void Main4(string[] args)
        {
            _items.Add(new Item() { ItemType = ItemType.Weapon, Rarity = Rarity.Normal });
            _items.Add(new Item() { ItemType = ItemType.Armor, Rarity = Rarity.Uncommon });
            _items.Add(new Item() { ItemType = ItemType.Ring, Rarity = Rarity.Rare });

            // Anonymous Function : 무명 함수 / 익명 함수 (초기의 람다 방식)
            //Item item = FindItem(delegate (Item item) { return item.ItemType == ItemType.Weapon; });

            // Lambda 함수를 사용하면 이렇게 일회성 함수의 작성이 가능합니다.(일회성 함수 제작)
            //Item item = FindItem((Item item) => { return item.ItemType == ItemType.Weapon; });

            // 코드를 더 줄이면 아래처럼 작성해서 사용도 가능합니다.
            Func<Item, bool> selector = (Item item) => { return item.ItemType == ItemType.Weapon; };
            Item item = FindItem(selector);

            // 그리고 실제로 MyFunc 처럼 사용하는 경우가 이미 C# 에 Func 라는 함수로 존재합니다.
            // 그런데, Func 함수를 보면 out 으로 TResult 가 있는 타입인데, 이는 void 형으로 return 하는 함수도 만들 수 있습니다.
            // 이런 경우 Action 이라는 타입이 사용 가능합니다.

            // 결론적으로 Delegate를 직접 선언하지 않아도 이미 만들어진 함수가 존재합니다.
            // -> 반환 타입이 있을 경우 Func
            // -> 반환 타입이 없을 경우 Action 을 사용하면 됩니다.

            // 그래서 실제로 사용할 때는 아래처럼 사용하면 됩니다.
            Item item2 = FindItem((Item item) => { return item.ItemType == ItemType.Weapon; });
        }
    }
}
