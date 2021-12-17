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
        static public bool Is(bool a, bool b)
        {
            return a == b;
        }
    }
}
