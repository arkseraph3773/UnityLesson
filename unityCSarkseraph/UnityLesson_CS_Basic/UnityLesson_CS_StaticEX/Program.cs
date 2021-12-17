using System;

namespace UnityLesson_CS_StaticEX
{
    class Program
    {
        static void Main(string[] args)
        {
            Orc orc1 = new Orc();
            orc1.name = "오크";
            orc1.height = 240.0f;

            Orc.typeName = "오크 타입 설계도";
            Orc.SayTypeName();

            // static 멤버(변수와 함수)는 객체 단위로 접근할수가 없다.
            // static으로 정의된 클래스는 인스턴스화가 불가능하다.
        }
    }
    public class Orc //오크의 정보 (변수)
    {
        //접근제한자
        //자료형 앞에 붙어서 해당 변수 함수 클래스의 접근권한을 지정한다.
        //public : 다른 클래스에서 접근 가능
        //private : 다른 클래스에서 접근이 불가능
        //protected : 상속자만 접근 가능
        public string name; //이름 //static public이면 메인함수에 엑세스 할수 없다
        public float height; //키
        public float weight; //몸무게
        public int age; //나이
        public char genderChar; //성별
        public bool isState; //움직임상태

        //static 키워드는 정적 성질을 부여하는 키워드
        //정적이라는 것은 메모리에 할당할수가 없다라는 뜻.
        //반대로 동적은 메모리 할당이 가능하다.
        static public string typeName;
        static public void SayTypeName()
        {
            Console.WriteLine(typeName);
        }
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
    }
    static class MapPortalZone //맵같이 불러올 필요없는 것
    {
        // static class를 쓰는 이유
        // 객체를 찍어내는 것이 아니라, 정보 기능 개념등이 유일하게 필요한 경우 사용
        //
    }
}
