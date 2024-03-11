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
        class Monsters
        {
            public int id;
            public Monsters(int id) { this.id = id; }

        }

        static void Main(string[] args)
        {
            // Dictionary
            // 만약 몬스터가 있다고 했을 때 리스트로 접근한다고 가정합니다.
            // 그런데 이 단위가 100만 마리 이런식으로 범위가 너무 커지면 리스트는 너무 느리다는 점이 있습니다.
            // 그래서 이를 보다 쉽게 찾기 위해서 Key 값으로 접근하는 방법이 있습니다.
            // Key 값으로 탐색해서 Value 를 가져옵니다.

            // Dictionary 는 Hashtable 이라는 기법을 사용합니다.
            // 예로 아주 큰 박스가 하나 있고 이 안에 공이 10000개가 들어가 있으며 이 공에 숫자가 기입되어있다고 합니다.
            // 이곳에서 원하는 숫자가 쓰여진 공을 찾는다고 가정합니다. 그러면 하나씩 찾아야 합니다.
            // 하지만, 이 Hashtable 의 경우 박스 여러개를 쪼개 놓는다고 생각해봅니다.
            // 그러면 [1~10] [11~20] ... [9990~10000] 이런식으로 10000만개를 조금 더 쪼개서 나눠 담습니다.
            // 이렇게 하면 이제 특정 번호에 해당하는 공(데이터)을 찾는다고 할 때, 보다 빠르게 찾는 것이 가능해집니다.
            // 다만, 이 방법은 이런식으로 박스를 많이 준비하게 되면 그만큼 메모리 소비량이 늘어나는 단점이 있습니다.
            // 그래서 메모리는 더 사용하지만 대신 속도에 있어서 이점을 가지는 형태가 됩니다.

            // 다만, 아래처럼 사용할 떄 Value 를 통해서 Key 값을 가져오는 거꾸로 하는 방법은 불가능합니다.
            // Dictionary 자료구조 선언
            Dictionary<int, Monsters> dic = new Dictionary<int, Monsters>();

            for (int i = 0; i < 10000; i++)
            {
                dic.Add(i, new Monsters(i));
                //dic[5] = new Monsters(5);
            }

            // 탐색해서 가져오기
            Monsters mon = dic[5000];

            // dic[5000] 방식으로 접근하면 없을 때 에러를 발생합니다.
            // 하지만, 아래처럼 TryGetValue 를 사용하면 에러를 방지할 수 있습니다.(반환값 bool)
            Monsters mons;
            bool found = dic.TryGetValue(20000, out mon);

            // 삭제 및 초기화
            dic.Remove(7777);   // 인덱스로 접근해서 삭제
            dic.Clear();
        }
    }
}
