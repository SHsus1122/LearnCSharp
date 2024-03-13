using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class CSharpPractice2
    {
        static int Find()
        {
            // 이처럼 무언가를 찾는다고 가정했을 때 일반적으로 못 찾으면 아래처럼
            // 0 이나 -1 을 반환하는 경우가 있습니다. 그런데 이런 경우에 Null 을 쓰는 것이 좋습니다.
            // 왜냐하면 0 이라는 값도 실제로 사용할 수도 있기 때문입니다.
            // 여기서 C# 에서 Nullable 이라는 타입을 지원해줍니다.
            return 0;
        }

        class Mob
        {
            public int Id { get; set; }
        }

        static void Main(string[] args)
        {
            // NUll 또한 클래스입니다.
            // 아래처럼 int 뒤 ? 를 붙이면 이제 number 는 Null 도 될 수 있다는 의미가 됩니다.
            int? number = null;

            //number = 3;

            // number 안의 값이 null 이 아니면 값을 가져와서 b에 넣어주고
            // 아니라면 초기값으로 지정한 0 을 넣어준다는 의미입니다.(삼항 연산자와 유사한 사용방식)
            int b = number ?? 0;

            if (number != null)
            {
                int a = number.Value;
                Console.WriteLine(a);
            }

            if (number.HasValue)
            {
                int a = number.Value;
                Console.WriteLine(a);
            }

            Mob mob = null;
            if (mob != null)
            {
                int monId = mob.Id;
            }

            // 이 코드의 의미는 mob 의 Id 를 가져와서 id 변수에 담을 것인데 만약 이 mob 이라는 변수가 null 이라면 null 을 넣는 다는 의미이며,
            // 아닐 경우 정상적으로 mob 의 Id 를 담게 됩니다.
            int? id = mob?.Id;
        }
    }
}
