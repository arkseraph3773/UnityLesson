using System;

namespace UnityLesson_CS_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr_PersonName = new string[6];
            arr_PersonName[0] = "김모씨";
            arr_PersonName[1] = "이모씨";
            arr_PersonName[2] = "김모씨";
            arr_PersonName[3] = "이모씨";
            arr_PersonName[4] = "김모씨";
            arr_PersonName[5] = "이모씨";

            int length = arr_PersonName.Length;
            //for문 기본형태
            /*for (index용 변수 선언 및 초기화; for문을 실행할 조건; 루프가 한번 실행될때마다 실행할 구문)
            {

            }*/
            /*for (int i = 0; i < length; i++)
            {
                Console.WriteLine(arr_PersonName[i]);
            }*/
            //김모씨만 출력하고싶을때
            //if문 사용 예제
            /*for (int i = 0; i < length; i++)
            {
                if(arr_PersonName[i] == "김모씨")
                {
                    Console.WriteLine(arr_PersonName[i]);
                }
            }*/
            //2n (n은 양의 정수)마다 김모씨 라는 규칙을 활용 예제
            for (int i = 0; i < length; i+=2)
            {
                Console.WriteLine(arr_PersonName[i]);
            }
        }
    }
}
