// See https://aka.ms/new-console-template for more information

// delegate(대리자)
// 함수의 인자로 함수를 받고 싶을때 사용

//delegate 반환형 델리게이트이름(인자);

namespace UnityLesson_CS_Delegate
{
    class Program
    {
        delegate int CalcDelegate(int a, int b);

        static void Main(string[] args)
        {
            int a = 4;
            int b = 7;
            /*int sumValue;
            int subValue;
            int divValue;
            sumValue = Sum(a, b);
            subValue = Sub(a, b);
            divValue = Div(a, b);
            PrintCalc(sumValue, subValue, divValue);*/

            CalcDelegate CD_Sum = Sum;
            CalcDelegate CD_Sub = Sub;
            // 람다식 : 함수를 정의하지 않고 연산에 필요한 내용만 표현하는 방법.
            // 객체지향이 아닌 함수지향
            CalcDelegate CD_Div = Div;
            /*CalcDelegate CD_Div = delegate (int a, int b)
            {
                return a / b;
            }; //이게 람다식*/ //메인 함수 밑에 따로 정의하지 않고 사용
            PrintCalc(a, b, CD_Sum, CD_Sub, CD_Div);
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Sub(int a, int b)
        {
            return a - b;
        }

        static int Div(int a, int b)
        {
            return a / b;
        }
        static void PrintCalc(int a, int b, CalcDelegate sum, CalcDelegate sub, CalcDelegate div)
        {
            Console.WriteLine($"Sum : {sum(a,b)}");
            Console.WriteLine($"Sub : {sub(a,b)}");
            Console.WriteLine($"Div : {div(a,b)}");
        }
        
    }
}