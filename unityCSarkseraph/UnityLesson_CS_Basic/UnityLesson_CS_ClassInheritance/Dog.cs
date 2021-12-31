using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLesson_CS_ClassInheritance
{
    class Dog : Creature , iFourLeggedWalker
    {
        public float tailLength;

        public void FourLeggedWalker()
        {
            Console.WriteLine("네발로 걷는다");
        }
    }
}
