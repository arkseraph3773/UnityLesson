using System;
using System.Collections.Generic;

namespace UnityLesson_CS_ClassInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Creature creature = new Creature();
            creature.Breath();

            Person person = new Person();
            person.Breath();

            Dog dog = new Dog();
            dog.Breath();
            // 인종들에게 걷게 만들기
            YellowMan yellowMan1 = new YellowMan();
            BlackMan blackMan1 = new BlackMan();
            WhiteMan whiteMan1 = new WhiteMan();

            yellowMan1.TwoLeggedWalk();
            blackMan1.TwoLeggedWalk();
            whiteMan1.TwoLeggedWalk();

            //인터페이스로 묶기
            iTwoLeggedWalker yellowMan1_iTwoLeggedWalker = yellowMan1;
            iTwoLeggedWalker blackMan1_iTwoLeggedWalker = blackMan1;
            iTwoLeggedWalker whiteMan1_iTwoLeggedWalker = whiteMan1;

            //list 사용
            List<iTwoLeggedWalker> list_twoLeggedWalker = new List<iTwoLeggedWalker>();
            list_twoLeggedWalker.Add(yellowMan1_iTwoLeggedWalker);
            list_twoLeggedWalker.Add(blackMan1_iTwoLeggedWalker);
            list_twoLeggedWalker.Add(whiteMan1_iTwoLeggedWalker);

            foreach (iTwoLeggedWalker twoLeggedWalker in list_twoLeggedWalker)
            {
                twoLeggedWalker.TwoLeggedWalk();
            }
        }
    }
}
