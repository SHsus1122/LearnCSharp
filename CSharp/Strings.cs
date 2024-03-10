using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharp
{
    internal class Strings
    {
        static void Main3(string[] args)
        {
            string name = "Harry Portter";

            // 1. 찾기
            bool found = name.Contains("Harry");

            // 특정 문자를 찾아서 몇 번째에 있는지 index 값을 반환
            Console.WriteLine(name.IndexOf("P"));   // 결과 : 6

            // 2. 변형
            name = name + " Junior";
            Console.WriteLine(name);                // 결과 : Harry Portter Junior

            // 소문자로 변형
            string lowerCaseName = name.ToLower();
            string upperCaseName = name.ToUpper();
            Console.WriteLine(lowerCaseName);       // 결과 : harry portter junior
            Console.WriteLine(upperCaseName);       // 결과 : HARRY PORTTER JUNIOR

            Console.WriteLine(name.Replace('r', 'l'));  // 결과 : Hally Polttel Juniol

            // 3. 분할
            // 띄어쓰기 ' ' 를 기준으로 분할해서 배열에 저장
            string[] names = name.Split(new char[] { ' ' });
            for (int i = 0; i < names.Length; i++)
                Console.WriteLine(names[i]);
            // 결과 : Harry
            //        Portter
            //        Junior

            // 원하는 위치부터 문자열을 잘라서 저장
            string subName = name.Substring(6);
            Console.WriteLine(subName);             // 결과 : Portter Junior
        }
    }
}
