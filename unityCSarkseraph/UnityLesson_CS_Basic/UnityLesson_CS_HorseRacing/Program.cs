/*프로그램 시작시
말 다섯마리를 만들고
각 다섯마리는 초당 10~20 (정수형) 범위 거리를 랜덤하게 움직임
각각의 말이 거리 200 에 도달하면 말의 이름과 등수를 출력해줌

말 클래스는
이름, 달린거리 를 멤버변수로
달리기 를 멤버 함수로 가짐.
달리기 멤버함수는 입력받은 거리를 달린거리에 더해주어서 달린거리를 누적시키는 역할을 함.

매초 달릴 때 마다 각 말들이 얼마나 거리를 이동했는지 콘솔창에 출력해줌.
경주가 끝나면 1,2,3,4,5 등 말의 이름을 등수 순서대로 콘솔창에 출력해줌.*/

/*-Hint -
System.Threading namespace 에 있는 Thread.Sleep(1000); 를 사용하면 현재 프로그램을 
1초 지연시킬수 있음
While 반복문에서 Thread.Sleep(1000); 을 추가하면 1초에 한번씩 반복문을 실행함.*/

using System.Threading;
namespace UnityLesson_CS_HorseRacing
{
    class Program
    {
        static Random random; //말의 달리는 속도를 랜덤하게 생성하기 위한 난수 변수
        static bool isGameFinished = false; // 경주가 끝났는지 체크하는 변수
        static int minSpeed = 10; // 달리는 속도의 최소값
        static int maxSpeed = 20; // 달리는 속도의 최대값
        static int finishDistance = 200;

        static void Main(string[] args)
        {
            Horse[] arr_Horse = new Horse[5]; //말 생성 인스턴스화 시키기 위한 배열
            string[] arr_FinishedHorseName = new string[5];  // 결승점을 통과한 말의 이름을 저장할 배열
            int currentGrade = 1; // 현재 등수
            int length = arr_Horse.Length; // 말들이 저장된 배열의 길이
            for (int i = 0; i < length; i++) // 말들을 인스턴스화 시키고 
            {
                arr_Horse[i] = new Horse(); // 말 인스턴스화
                arr_Horse[i].name = "경주마" + i +1; // 말의 이름 초기화
            }
            Console.WriteLine("뛰어라!");
            int count = 0; //while 문이 돈 횟수
            while(isGameFinished == false) //!isGameFinished는 not //게임이 끝날때까지 돌아가는 while문
            {
                Console.WriteLine($"================= {count} 초 ================="); // count는 1초에 1씩 올라감(이유 : while문 마지막에 thread.Sleep(1000)으로 1초 지연이 있기때문)
                for (int i = 0; i < length; i++) // 랜덤한 속도로 말을 달리게 하는 for문
                {
                    if (arr_Horse[i].dontMove == false) //i번째 말이 움직일수 있으면 
                    {
                        random = new Random(); // 난수용 인스턴스
                        int tmpMoveDistance = random.Next(minSpeed, maxSpeed + 1); // minSpeed(10) ~ maxSpeed(20) 범위 내의 난수 생성
                        arr_Horse[i].Run(tmpMoveDistance); // i 번째 말을 tmpMoveDistance만큼 달림(10~20사이 정수)
                        //arr_Horse[i].Run(10 과 20사이의 정수);
                        Console.WriteLine($"{arr_Horse[i].name}(이)가 달린거리 : {arr_Horse[i].distance}"); // {i번째 말이름} 이 달린거리 {i번째 말이 달린거리} 출력
                        if (arr_Horse[i].distance >= finishDistance) //i번째 말이 달린거리가 결승점 거리보다 크거나 같을때 (i번째 말이 결승점을 통과했으면)
                        {
                            arr_Horse[i].dontMove = true; // i번째 말을 더이상 달리지 않도록 해줌
                            arr_FinishedHorseName[currentGrade - 1] = arr_Horse[i].name; // 결승점에 도달한 말의 이름을 현재 등수 -1 번째 자리에 대입
                            currentGrade++; // 현재 등수를 1 증가
                        }
                    }
                }
                Console.WriteLine($"==================================");
                if (currentGrade > 5) // 현재 등수가 5보다 크면 즉, 1에서 5등까지 전부 결승점에 들어왔으면
                {
                    isGameFinished = true; // 게임이 끝났다.
                    Console.WriteLine("경주는 끝났다.");
                    break; //끝나고도 1초 지연시키려면 break지움 //while loop탈출
                }
                Thread.Sleep(1000); // 1000 ms = 1 sec. //1초 지연
                count++; //while문 돈 횟수 증가
            }
            Console.WriteLine("===========결과 발표===========");
            for (int i = 0; i < length; i++) //경주가 끝난말의 이름을 등수대로 출력해주는 for 문
            {
                Console.WriteLine($"{i + 1} 등 : {arr_FinishedHorseName[i]}");
            }
        }
    }
}