using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLesson_CS_Operator
{
    class FunctionsForOperation
    {
        //산술연산
        //==================================================================
        //덧셈
        static public int Sum(int a, int b)
        {
            return a + b;
        }
        //함수 오버로딩
        //같은 기능을 수행하는 함수의 이름을 똑같이 하고
        //인수(arguments) 의 타입만 변경하면 같은 이름의 함수를 여러개 만들수 있는 기능
        //뺄셈
        static public int Sub(int a, int b)
        {
            return a - b;
        }
        //나눗셈
        static public int Div(int a, int b)
        {
            return a / b;
        }
        //곱셈
        static public int Mul(int a, int b)
        {
            return a * b;
        }
        //나머지
        static public int Mod(int a, int b)
        {
            return a % b;
        }
        //증가연산
        static public int Increase(int a)
        {
            return a++;
        }
        //감소연산
        static public int Decrease(int a)
        {
            return a--;
        }
        //관계연산
        static public bool IsSame(bool a, bool b)
        {
            return a == b;
        }
        static public bool IsDiffernt(bool a, bool b)
        {
            return a != b;
        }
        static public bool IsSmaller(int a, int b)
        {
            return a < b;
        }
        static public bool IsBiggerOrSame(int a, int b)
        {
            return a >= b;
        }
        static public bool IsSmallerOrSame(int a, int b)
        {
            return a <= b;
        }
        static public int PlusBToA(int a, int b)
        {
            a += b;
            return a;
        }
        static public int MinusBToA(int a, int b)
        {
            a -= b;
            return a;
        }
        static public int MultiplyBToA(int a, int b)
        {
            a *= b;
            return a;
        }
        static public int BivodeBToA(int a, int b)
        {
            a /= b;
            return a;
        }
        static public int ModBToA(int a, int b)
        {
            a %= b;
            return a;
        }
    }
}
