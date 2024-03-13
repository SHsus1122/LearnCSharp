using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class CSharpPractice2
    {
        // 커스텀 타입 예외 처리 작성법
        class TestException : Exception
        {
            
        }

        static void Main(string[] args)
        {
            try
            {
                // 예외적인 상황들에 대한 상황 예시
                //  1. 0으로 나눌 떄
                //  2. 잘못된 메모리를 참조하는 경우(null, 캐스팅 실패 등)
                //  3. 오버플로우 발생 시

                // 커스텀 예외처리 발동
                throw new TestException();
            }
            catch (DivideByZeroException e)
            {

            }
            catch (Exception e)
            {

            }
            finally
            {
                // 반드시 처리되어야 할 코드는 이곳에 작성
            }
        }
    }
}
