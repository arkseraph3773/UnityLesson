using System;

/*namespace UnityLesson_CS_IF
{
    class Program
    {
        static bool doPrint = true;// 기본값은 거짓
        static void Main(string[] args)
        {
            if (doPrint == true)
            {
                Console.WriteLine("Hello World!");
            }

        }
    }
}*/

namespace UnityLesson_CS_IF
{
    class Program
    { //if문 여러개 사용 하면 출력문 전부 뽑아낼수 있음.
        // else if문은 if문이 false일때 출력되는것
        static bool condition1 = true;// 기본값은 거짓
        static bool condition2 = true;
        static bool condition3 = true;
        static void Main(string[] args)
        {
            //만약 소괄호 안의 조건이 참이면 중괄호 안의 내용을 실행한다.
            if (condition1)//조건1
            {
                Console.WriteLine("조건1이 참"); //조건1이참일때 실행할내용
            }
            else if(condition2)//조건2
            {
                Console.WriteLine("조건1이 거짓 조건2가 참"); //조건1이 거짓일때 실행할 내용
            }
            else if(condition3)//조건3
            {
                Console.WriteLine("조건 1,2가 거짓 조건3이 참"); //조건 1,2가 거짓이고 조건 3이 참일때 실행
            }
            else //조건4
            {
                Console.WriteLine("ALL FLASE"); //조건 1,2,3 모두 거짓일때 실행됨
            }
        }
    }
}