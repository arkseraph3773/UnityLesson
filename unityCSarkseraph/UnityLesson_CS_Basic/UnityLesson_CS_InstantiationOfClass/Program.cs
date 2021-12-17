using System;

namespace UnityLesson_CS_InstantiationOfClass
{
    class Program
    {
        //접근제한자
        //위치 : 자료형 앞
        //아무것도 안적혀있으면 디폴트값이 private
        //public, protected, private
        //public 다른 클래스에서 전부 접근 가능
        //private 다른 클래스에서 접근 불가능
        //protectes 상속자만 접근이 가능하다
        static void Main(string[] args)
        {
            Person person1 = new Person();
            // .연산자 
            //클래스의 멤버에 접근할때 사용, namespace안의 클래스에 접근할때 사용
            //System.Console.WriteLine();
            person1.age = 40; //정수형은 그냥 숫자 입력
            person1.height = 223.4f; // 실수형은 숫자 뒤에 f 추가 입력
            person1.isFemale = false; // 논리형은 true, false
            person1.genderChar = '남'; //문자형은 ''작은 따옴표 안에 단일 문자
            person1.name = "김남자"; //문자열형은 ""큰 따옴표 안에 다중문자

            person1.SayAllInfo();

            Person person2 = new Person();
            person2.age = 20; //정수형은 그냥 숫자 입력
            person2.height = 163.4f; // 실수형은 숫자 뒤에 f 추가 입력
            person2.isFemale = true; // 논리형은 true, false
            person2.genderChar = '여'; //문자형은 ''작은 따옴표 안에 단일 문자
            person2.name = "박여자"; //문자열형은 ""큰 따옴표 안에 다중문자

            person2.SayAllInfo();
        }
    }
    class Person
    {
        public int age;
        public float height;
        public bool isFemale;
        public char genderChar;
        public string name;

        public void SayAllInfo() //한번에 전부 불러옴
        {
            SayAge();
            SayHeight();
            SayIsFemale();
            SayGenderChar();
            SayName();
        }

        //입력 -> 함수기능 -> 출력
        public void SayAge() //소괄호 안에 있는것이 입력 중괄호 안에 있는것이 함수 기능
        {
            Console.WriteLine(age);
        }
        public void SayHeight()
        {
            Console.WriteLine(height);
        }
        public void SayIsFemale()
        {
            Console.WriteLine(isFemale);
        }
        public void SayGenderChar()
        {
            Console.WriteLine(genderChar);
        }
        public void SayName()
        {
            Console.WriteLine(name);
        }
    }
}

