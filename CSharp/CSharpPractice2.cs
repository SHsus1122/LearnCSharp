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
        class Important : System.Attribute
        {
            string message;

            public Important(string message) { this.message = message; }
        }

        class Mob
        {
            // hp 라는 정보가 만약 중요한 정보라고 가정합니다.
            // 하지만, 컴퓨터 입장에서 보면 이는 컴파일도 안하고 그냥 지워버리는 정보입니다.
            // 그런데 이런 경우 attribute 를 사용하면 실제로 런타임에서도 참고할 수 있는 힌트를 남길 수 있습니다.
            [Important("Very Important !!")]    // Attribute 사용

            public int hp;
            protected int attack;
            private float speed;

            void Attack() { }
        }

        static void Main(string[] args)
        {
            // Reflection 사용 예
            Mob mob = new Mob();

            // 이 GetType 이라는 것이 만들지 않았는데 사용 가능한 것을 볼 수 있습니다.
            // 이는 C# 에서 만드는 모든 객체들은 다 Object 객체에서 파생되어서 나왔기 때문입니다.
            // 그래서 이 말고도 Equals, toString 등 다양한 함수가 존재하는 것을 볼 수 ㅇㅆ습니다.
            // 그래서 이렇게 Type 도 대체가 가능합니다.
            Type type = mob.GetType();

            var fields = type.GetFields(System.Reflection.BindingFlags.Public
                | System.Reflection.BindingFlags.NonPublic
                | System.Reflection.BindingFlags.Static
                | System.Reflection.BindingFlags.Instance);

            foreach ( FieldInfo field in fields)
            {
                string access = "protected";
                if (field.IsPublic) access = "public";

                else if(field.IsPrivate) access = "private";

                var attributes = field.GetCustomAttributes();

                Console.WriteLine($"{access} {field.FieldType.Name} {field.Name}");
            }
        }
    }
}
