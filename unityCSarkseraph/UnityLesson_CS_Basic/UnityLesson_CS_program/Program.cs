//using 키워드 미리 지정되있는것
// using 뭔가를 사용하겠다 라고 선언하는 키워드
// system 이라는걸 사용하겠다. 라는뜻.
// using은 언제쓰나
// 예시) 특정한 네임스페이스를 쓰겠다고 선언
// 만약에 UnityLesson_CS_program2라는 namespace의 클래스 등 정보를 가져와 쓰고싶다
// using UnityLesson_CS_program2 라고 스크립트 최 상단에 선언 해줌
// 예시2) 우선순위가 차순위인 함수 호출
// UnityEngine.Physics , Unity.Physics
// 두가지중에 기본적으로는 UnityEngine.Physics가 우선순위
// 두 네임스페이스 모두Raycast()라는 함수를 포함하고 있다.
// 근데 나는 Unity.Physics.Raycast()를 쓰고싶다.
// 일반적으로 RayCast() 를 호출하면 -> UnityEngine.Physics.Raycast()가 호출된다.
// using RayCast = Unity.Physics.Raycast;
// 라고 해주면 Raycast() 호출했을때 Unity.Physics.Raycast()가 호출됨.
using System;//전처리 지시자

//namespace 이름의 공간
// 다른 프로그램에 있는 클래스를 사용하기 위해서 충돌을 막기 위해 사용
// 클래스 간의 맴버 이름 충돌을 방지함
namespace UnityLesson_CS_program 
{
    // 실행파일(.exe)을 실행하면 가장먼저 메인함수부터 찾는다.
    // Program Class
    // 모든 프로젝트는 처음 실행파일(.exe)을 통해 실행될때에
    //Main()함수를 실행하며
    //C#에서는 Main 함수조차도 객체 지향컨셉에 맞게 Program이라는 클래스 안에 선언되어있음.
    class Program
    {
        //static 키워드:
        //static(정적) 은 dynamic(동적)의 반대개념 키워드
        //static은 상황에 따라 메모리에 할당할수 없는 성질
        //dynamic은 상황, 조건에 따라 메모리에 할당할수 있는 성질
        //Main함수는 static으로 정의되었으므로 하나만 존재할수 있다.
        //static 클래스 함수 메인 어디에도 붙힐수 있다.
        //만약에 class에 static이 붙는다.
        //그러면 그에 딸린 모든 변수나 함수도 static 이어야함.
        //class에 static이 안붙었다 

        //void 자료형
        //void 반환값이 없다.
        //입력을 받으면 기능을 수행하고 출력을 한다
        //void 를 반환하는 함수는 : 입력 -> 기능수행 끝

        //args는?
        //arguments 인자, 인수
        //함수에서 받을 입력
        //표기방법은 함수 이름 뒤에 괄효열고 "자료형" "인자이름" 형태로 써준다.
        static void Main(string[] args)
        {
            //Console이란?
            //클래스
            //system안에 미리 들어있으니 따로 선언 안해줘도 된다.
            //using으로 선언했던 system이라는 namespace안에 있는 클래스
            Console.WriteLine("Hello World!");
            //system.Console.WriteLine("Hello World!"); using System이 없으면 앞에 system입력해서 처리
        }

       /* int a(int input)
        {
            return input;//리턴으로 반환한다.
        }*/


    }
}
