using System;

namespace UnityLesson_CS_Array
{
    class Program
    {
        // array
        // 형태 : 자료형[] static 클래스명[]
        // 자료형이 정적으로 나열되어 있는 형태
        // 즉 한번 크기를 정해놓으면 바꿀수 없다.
        // 
        static int[] arr_testInt = new int[5]; //배열의 길이값new 자료형[]안에 숫자
        static float[] arr_testFloat = new float[3];
        static float[] arr_testFloat2 = { 1.0f, 2.0f, 3.0f, 4.0f};
        static string[] arr_testString = new string[3];
        static void Main(string[] args)
        {
            arr_testInt[0] = 5;
            arr_testInt[1] = 4;
            arr_testInt[2] = 3;
            arr_testInt[3] = 2;
            arr_testInt[4] = 1;

            Console.WriteLine(arr_testInt[0]);
            Console.WriteLine(arr_testInt[1]);
            Console.WriteLine(arr_testInt[2]);
            Console.WriteLine(arr_testInt[3]);
            Console.WriteLine(arr_testInt[4]);

            arr_testFloat[0] = 2.0f;
            arr_testFloat[1] = 4.0f;
            arr_testFloat[2] = 6.0f;

            Console.WriteLine(arr_testFloat[0]);
            Console.WriteLine(arr_testFloat[1]);
            Console.WriteLine(arr_testFloat[2]);

            arr_testString[0] = "김모씨";
            arr_testString[1] = "박모씨";
            arr_testString[2] = "정모씨";

            Console.WriteLine(arr_testString[0]);
            Console.WriteLine(arr_testString[1]);
            Console.WriteLine(arr_testString[2]);

            
        }
    }
}
