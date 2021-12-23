using System;

namespace UnityLesson_CS_Operator
{
    class Program
    {
        static int a = 14;
        static int b = 5;
        static int c; //정수연산

        /*static float a = 14f;
        static float b = 5f;
        static float c; //실수연산*/
        static void Main(string[] args)
        {
            // 산술 연산
            // 더하기, 빼기, 나누기, 곱하기, 나머지
            //===================================================================
            // 더하기
            c = FunctionsForOperation.Sum(a, b);
            Console.WriteLine(c);
            //빼기
            c = FunctionsForOperation.Sub(a, b);
            Console.WriteLine(c);
            //나누기 -> 정수를 나누기 하면 결과값에서 소수점은 버린다.(나머지를 버린다)
            c = FunctionsForOperation.Div(a, b);
            Console.WriteLine(c);
            //곱하기
            c = FunctionsForOperation.Mul(a, b);
            Console.WriteLine(c);
            //나머지
            c = FunctionsForOperation.Mod(a, b);
            Console.WriteLine(c);

            //증감연산
            //증가연산자, 감소연산자
            //================================================================
            //증가연산
            c = FunctionsForOperation.Increase(c);
            /*c++; //c = c + 1;*/
            Console.WriteLine(c);
            //감소연산
            c = FunctionsForOperation.Decrease(c);
            /*c--; //c = c - 1;*/
            Console.WriteLine(c);

            //관계연산
            //같음 , 다름, 크기 비교 연산
            //관계연산의 결과가 참기면true, 거짓이면 false를 반환
            //================================================================
            //같은 비교
            Console.WriteLine(a == b);//a = b; //a값을 b에 대입하겠다
            //다름 비교
            Console.WriteLine(a != b);
            //크기 비교
            //크다
            Console.WriteLine(a > b);
            //작다
            Console.WriteLine(a < b);
            //크거나 같다
            Console.WriteLine(a >= b);
            //작거나 같다
            Console.WriteLine(a <= b);

            //대입연산
            //(더해서, 빼서, 나누어서, 곱해서, 나머지를) 대입
            //================================================================
            c = 20;
            Console.WriteLine($"Last C value : {c}");

            //더해서 대입
            c += b; //c = c + b;
            Console.WriteLine(c);
            //빼서 대입
            c -= b; //c = c - b;
            Console.WriteLine(c);
            //나눠서 대입
            c /= b; //c = c / b;
            Console.WriteLine(c);
            //곱해서 대입
            c *= b; //c = c * b;
            Console.WriteLine(c);
            //나머지를 대입
            c %= b; //c = c % b;
            Console.WriteLine(c);

            //논리연산
            //양측의 피연산자들을 비교해서 연산 수행
            // or, and, xor, not
            //===============================================================
            bool A = true;
            bool B = false;
            //or
            //a 와 b 둘중 하나라도 true이면 true 반환, 나머지 경우 false반환
            Console.WriteLine(A | B); //|는 시프트+\
            //and
            //a 와 b 둘다 true일때만 true 반환, 나머지 경우 false반환
            Console.WriteLine(A & B);
            //xor
            //a 와 b 둘중에 하나만 true일때 true반환, 나머지 경우 false반환
            Console.WriteLine(A ^ B);
            //not
            //a 의 반대 부호 반환(ture이면 false, false이면 ture반환)
            Console.WriteLine(!A);
            /*Console.WriteLine(!B);*/

            //조건부 논리연산
            //왼쪽 피연산자 조건에 따라서 오른쪽 피연산자와 비교할지 말지 평가 후에 연산한다
            //==============================================================
            //or 조건부 논리연산
            //만약 a가 true 이면 B의 값에 관계없이 결과값이 true이므로
            //연산을 하지 않고 A 값을 반환함.
            Console.WriteLine(A || B);
            
            //and 조건부 논리연산
            //만약 A가 false면 B의 값에 관계없이 결과값이 false이므로
            //연산을 하지 않고 A값을 반환함.
            Console.WriteLine(A && B);

            // 비트 연산 //멀티게임같은거 만들때 데이터 줄이기 위해서 사용
            // 비트연산을 하는 이유 : 데이터를 효율적으로 관리하기 위함
            int howManyBitYouWantToShift = 1;
            // or, and, xor, not, shift-left, shift-right
            //or
            Console.WriteLine(a | b);
            //and
            Console.WriteLine(a & b);
            //xor
            Console.WriteLine(a ^ b);
            //not
            Console.WriteLine(~a);
            //shift-left
            Console.WriteLine(a << howManyBitYouWantToShift); //(a<<1) 뒤에 숫자에 따라 밀려나는 비트
            //shift-right
            Console.WriteLine(a >> howManyBitYouWantToShift);

        }
    }
    //Finite State Machine 유한 상태머신(상태의 개수가 정해진 머신)
    //클래스의 상태에 따라 다른동작을 하기위해 사용
    //ex)플레이어가 idle상태면 마을로 귀환이 가능하고 피격당한 상태와 공격중인 상태일때 귀환이 불가능하게 성정하고 싶으면
    //플레이어의 FSM을 만들어서 상태를 나누고 귀환이 가능한 조건을 FSM으로 구분한다.
    //즉 사용자가 귀환 버튼을 눌렀을때, idle상태면 귀환버튼이 실행되면서 귀환을 시전하고
    [Flags]
    public enum e_FSM  
    {
        IDLE = 0, //IDLE(기본대기상태)
        피격당한상태 = 1 << 0,
        공격당한상태 = 1 << 1,
        STATE_3 = 1 << 2,
        STATE_4 = 1 << 3,
    }
}
