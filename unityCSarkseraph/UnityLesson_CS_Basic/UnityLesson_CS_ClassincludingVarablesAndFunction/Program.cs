using System;

namespace UnityLesson_CS_ClassincludingVarablesAndFunction
{
    class Program
    {
        static void Main(string[] args)
        {
        
        }
    }
    class Person
    {
        int age;
        float height;
        bool isFemale; 
        char genderChar; 
        string name; 

        void SayAllInfo() //한번에 전부 불러옴
        {
            /*Console.WriteLine(age);
            Console.WriteLine(height);
            Console.WriteLine(isFemale);
            Console.WriteLine(genderChar);
            Console.WriteLine(name);*/
            SayAge();
            SayHeight();
            SayIsFemale();
            SayGenderChar();
            SayName();
        }

        //입력 -> 함수기능 -> 출력
        void SayAge() //소괄호 안에 있는것이 입력 중괄호 안에 있는것이 함수 기능
        {
            Console.WriteLine(age);
        }
        void SayHeight()
        {
            Console.WriteLine(height);
        }
        void SayIsFemale()
        {
            Console.WriteLine(isFemale);
        }
        void SayGenderChar()
        {
            Console.WriteLine(genderChar);
        }
        void SayName()
        {
            Console.WriteLine(name);
        }
    }
}
