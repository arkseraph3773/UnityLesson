using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLesson_CS_ClassInheritance
{
    class WhiteMan : Person
    {
        public override void Breath()
        {
            /*base.Breath();*/
            /*Creature.Breath();
            height += 0.00004f;
            weight += 0.00002f;*/ //base.Breath(); 풀어쓴거

            lifeTime++;
            height += 0.00008f;
            weight += 0.00004f;
        }
    }
}
