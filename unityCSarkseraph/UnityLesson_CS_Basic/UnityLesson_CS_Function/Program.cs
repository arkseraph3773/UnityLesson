using System;

namespace UnityLesson_CS_Function
{
    class Program
    {
        static bool doPrintHelloWorld = true; //false 입력시 출력 안됨
        static bool doPrintsomething = true;
        static void Main(string[] args)
        {
            //함수 호출시 함수이름(); 형태로 호출한다.
            if(doPrintHelloWorld == true)//false일시 else안에 있는 출력문이 출력된다.
            {
                PrintHelloWorld();
            }
            else
            {
                Console.WriteLine("do nothing");
            }
            //parameter : 함수 호출시 입력변수
            string something = "Unity hola"; //string을 표기하는 방법은 "" 이다
            if(doPrintsomething == true)
            {
                PrintSomething(something);
            }
            
        }

        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
        //내가 입력한 문자 출력
        static void PrintSomething(string something)
        {
            Console.WriteLine(something);
        }
    }
}
