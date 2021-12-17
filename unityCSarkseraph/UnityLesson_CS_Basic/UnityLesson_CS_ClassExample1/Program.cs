using System;

namespace UnityLesson_CS_ClassExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Orc orc1 = new Orc();

            orc1.name = "상급오크";
            orc1.height = 530.0f;
            orc1.weight = 250.0f;
            orc1.age = 400;
            orc1.genderChar = '남';
            orc1.isState = false;

            orc1.CheckisState();
            /*if (orc1.isState)
            {
                *//*Console.WriteLine($"{orc1.name}(이)가 점프했다!");*//*
                orc1.Jump();
                orc1.Smash();
            }
            else
            {
                Console.WriteLine($"{orc1.name}는 지금 바쁘다.");
            }*/

            //orc1.Name();
            /*orc1.Jump();
            orc1.Smash();*/

            Orc orc2 = new Orc();

            orc2.name = "하급오크";
            orc2.height = 330.0f;
            orc2.weight = 150.0f;
            orc2.age = 150;
            orc2.genderChar = '여';
            orc2.isState = true;

            /*orc2.CheckisState();*/

            if (orc2.isState)
            {
                /*Console.WriteLine($"{orc2.name}(이)가 점프했다!");*/
                orc2.Jump();
                orc2.Smash();
            }
            else
            {
                Console.WriteLine($"{orc2.name}는 지금 바쁘다.");
            }
            //orc2.Name();
            /*orc2.Jump();
            orc2.Smash();*/

        }
    }


    public class Orc //오크의 정보 (변수)
    {
        public string name; //이름
        public float height; //키
        public float weight; //몸무게
        public int age; //나이
        public char genderChar; //성별
        public bool isState; //움직임상태
        public void Jump() //함수
        {
            //Console.WriteLine(name + "(이)가 점프했다!");
            Console.WriteLine($"{name}(이)가 점프했다!");
        }
        public void Smash()
        {
            //Console.WriteLine(name + "휘두르기");
            Console.WriteLine($"{name}(이)가 휘둘렀다!");
        }

        public void CheckisState()
        {
            if (isState)
            {
                Smash();
            }
            else
            {
                Console.WriteLine($"{name}는 바쁘다.");
            }
        }

        /*public void Name()
        {
            Console.WriteLine(name);
        }*/
    }

    /*class User
    {
        public string name; //이름
        public float height; //키
        public float weight; //몸무게
        public int age; //나이
        public char genderChar; //성별
        public bool isState; //움직임상태

        public void Attack()
        {
            Console.WriteLine("공격");
        }
        public void Spell()
        {

        }
    }*/
}
