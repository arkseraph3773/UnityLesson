using System;

namespace UnityLesson_CS_WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //while문의 구조 while후 탭 2번 자동 입력
            /*while (조건)
            {   
                //조건이 참이면 반복할 내용
            }*/
            // 무한 루프(while문의 조건이 항상 참일 경우) 뜨면 안좋음
            /*while (true)
            {
            }*/
            //while문은 조건이 항상 참이면 무한으로 돌아가기때문에
            //프로그램이 멈추는 현상이 발생한다.
            //그래서 반드시 while문은 탈출할수 있는 조건을 입력해야 한다.
            //왠만하면 while문은 쓰지 않는다.
            //while뿐만 아니라 모든 반복문, 분기문은 함수 내에서만 사용가능

            string[] arr_PersonName = new string[3];
            arr_PersonName[0] = "김모씨";
            arr_PersonName[1] = "이모씨";
            arr_PersonName[2] = "정모씨";

            int length = arr_PersonName.Length;
            int count = 0;
            while (count < length)
            {
                Console.WriteLine(arr_PersonName[count]);
                count++;
            }

        }
    }
}
