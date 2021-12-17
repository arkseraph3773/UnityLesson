using System;

namespace UnityLesson_CS_Class_Object_Instance
{
    class Program
    {
        static void Main(string[] args)
        {
            //객체 생성
            //new키워드
            new AA(); //생성자 : 클래스 이름과 똑같은 함수. 객체를 생성함
            // 인스턴스화
            // 메모리 공간에 객체를 할당시킨다.
            // AA타임의 변수 a에 new AA()로 생성된 객체가 할당되었다.
            // 이제 new AA()로 생성된 객체가 필요할때마다
            // 변수 a를 통해서 new AA(로 생성된 객체에 접근할수 있게 되었다.
            // 그리고 이렇게 되었을때 new AA(로 생성된 객체를 인스턴스 라고 한다/
            // 이때 이 a를 인스턴스라고 함.
            AA a = new AA(); //객체의 변수화
            int i = 13;
        }

    }
    public class AA //설계도(클래스)
    {
        //생성자
        /*AA()
        {

        }*/
        //소멸자
        /*~AA()
        {

        }*/

    }
}
