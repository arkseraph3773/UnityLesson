using System;

//오크 객체를 10마리 만들고 오크들의 인스턴스는 오크타입 배열에 넣어준다
//각 오크의 이름은 "오크0","오크1"..........
//각 오크에게 isState의 값을 아무거나 넣어준다(true나 false중 아무거나)
//각 오크가 쉬고있는지 확인해서 쉬고있다면 점프하도록 한다.

namespace UnityLesson_CS_ForLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Orc[] arr_Orc = new Orc[10];
            int length = arr_Orc.Length;
            for (int i = 0; i < length; i++)
            {
                arr_Orc[i] = new Orc();
                arr_Orc[i].name = "오크" + i;
                arr_Orc[i].name = $"오크{i}";
            }
            for (int i = 0; i < length; i++)
            {
                arr_Orc[i].isState = GetRandomBool();
            }
            /*arr_Orc[0].isState = true;
            arr_Orc[1].isState = false;
            arr_Orc[2].isState = true;
            arr_Orc[3].isState = true;
            arr_Orc[4].isState = false;
            arr_Orc[5].isState = true;
            arr_Orc[6].isState = false;
            arr_Orc[7].isState = false;
            arr_Orc[8].isState = true;
            arr_Orc[9].isState = true;*/
            for (int i = 0; i < length; i++)
            {
                if (arr_Orc[i].isState)
                {
                    arr_Orc[i].Jump();
                }
            }
        }
        static public bool GetRandomBool()
        {
            Random rand = new Random();
            bool value = Convert.ToBoolean(rand.Next(0, 2)); //Convert.ToBoolean형변환
            return value;
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
    }
}
