using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLesson_CS_ClassInheritance
{
    class Person : Creature , iTwoLeggedWalker 
        //: 치고 상속받을 부모클래스 이름
    {
        public float height;

        // override : 부모의 virtual 키워드가 붙은 함수를 재정의 하는 키워드
        public override void Breath()
        {
            base.Breath();
            height += 0.00004f;
            weight += 0.00002f;
        }

        public void TwoLeggedWalk()
        {
            Console.WriteLine("두발로 걷는다");
        }
        /*public void TwoLeggedWalk()
        {
            Console.WriteLine("두발로 걷는다");
        }*/
    }
}
